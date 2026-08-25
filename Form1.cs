using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace VoteCraft
{
    public partial class  Form1 : Form
    {
        private readonly struct VoteSite
        {
            public string Name { get; }
            public string Url { get; }
            public VoteSite(string name, string url) { Name = name; Url = url; }
        }

        private const decimal VotesPerDay = 5m;
        private const string MinecraftUsername = "HiTechCharles";
        private const string ApplicationFolderName = "VoteCraft";
        private const string LogFileName = "VoteStats.txt";

        private readonly VoteSite[] _sites;

        private static readonly string CatPath;
        private static readonly string LogPath;

        static Form1()
        {
            // Prefer OneDrive consumer Documents folder when available; otherwise fallback to MyDocuments
            var oneDrive = Environment.GetEnvironmentVariable("onedriveconsumer");
            string documentsFolder = !string.IsNullOrWhiteSpace(oneDrive)
                ? Path.Combine(oneDrive, "documents")
                : Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            CatPath = Path.Combine(documentsFolder, ApplicationFolderName);
            LogPath = Path.Combine(CatPath, LogFileName);
        }

        public Form1()
        {
            InitializeComponent();

            // Ensure directory exists before any file IO
            Directory.CreateDirectory(CatPath);

            TrySetClipboard();

            // Central site list
            _sites = new[]
            {
                new VoteSite("Top MineCraft Servers", "http://topminecraftservers.org/vote/4613"),
                new VoteSite("MineCraft Servers.org", "https://minecraftservers.org/vote/525699"),
                new VoteSite("MineCraft Server List", "https://minecraft-server-list.com/server/434154/vote/"),
                new VoteSite("Minecraft MP", "https://minecraft-mp.com/server/211256/vote/"),
                new VoteSite("Minecraft Buzz", "https://minecraft.buzz/vote/7051"),
                new VoteSite("MC Java Wiki", "https://minecraft.fandom.com/wiki/Java_Edition")
            };

            // Assign button text from sites (buttons are created in designer)
            Site1BTN.Text = _sites[0].Name;
            Site2BTN.Text = _sites[1].Name;
            Site3BTN.Text = _sites[2].Name;
            Site4BTN.Text = _sites[3].Name;
            Site5BTN.Text = _sites[4].Name;
            WikiBTN.Text = _sites[5].Name;

            LoadFile();
            UpdateToGo();
        }

        /// <summary>
        /// Attempts to set the Minecraft username in the clipboard for easy pasting.
        /// </summary>
        private void TrySetClipboard()
        {
            try
            {
                Clipboard.SetText(MinecraftUsername);
            }
            catch (Exception ex)
            {
                // Clipboard can fail if called too early or in some security contexts
                Debug.WriteLine($"Failed to set clipboard: {ex.Message}");
            }
        }

        #region Site Buttons
        private void Site1BTN_Click(object sender, EventArgs e) => OpenSite(0, Site1BTN);
        private void Site2BTN_Click(object sender, EventArgs e) => OpenSite(1, Site2BTN);
        private void Site3BTN_Click(object sender, EventArgs e) => OpenSite(2, Site3BTN);
        private void Site4BTN_Click(object sender, EventArgs e) => OpenSite(3, Site4BTN);
        private void Site5BTN_Click(object sender, EventArgs e) => OpenSite(4, Site5BTN);
        private void WikiBTN_Click(object sender, EventArgs e) => OpenSite(5, WikiBTN);

        /// <summary>
        /// Opens a voting site in the default browser and provides visual feedback.
        /// </summary>
        /// <param name="index">Index of the site in the _sites array.</param>
        /// <param name="sourceButton">Button that triggered the action.</param>
        private void OpenSite(int index, Button sourceButton)
        {
            if (index < 0 || index >= _sites.Length) return;

            var site = _sites[index];

            if (!Uri.IsWellFormedUriString(site.Url, UriKind.Absolute))
            {
                MessageBox.Show($"Invalid URL: {site.Url}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // UseShellExecute = true so default browser opens the URL
                var psi = new ProcessStartInfo(site.Url) { UseShellExecute = true };
                Process.Start(psi);

                // Provide immediate visual feedback
                sourceButton.BackColor = System.Drawing.Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open URL:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        /// <summary>
        /// Calculates and displays the number of days until reaching the next level goal.
        /// </summary>
        private void UpdateToGo()
        {
            DateTime currentDate = DateTime.Now;
            decimal votesRemaining = NextLevelNUD.Value - VoteTotalNUD.Value;
            decimal daysRequired = 0;

            if (votesRemaining > 0)
            {
                daysRequired = Math.Round(votesRemaining / VotesPerDay, 0, MidpointRounding.AwayFromZero);
            }

            DateTime projectedDate = currentDate.AddDays(Convert.ToDouble(daysRequired));
            DaysTB.Text = $"{daysRequired}   {projectedDate.ToShortDateString()}";
        }

        #region Numeric UpDown Value Changed
        private void VoteTotalNUD_ValueChanged(object sender, EventArgs e) => UpdateToGo();
        private void NextLevelNUD_ValueChanged(object sender, EventArgs e) => UpdateToGo();
        #endregion

        /// <summary>
        /// Loads saved vote statistics from disk.
        /// </summary>
        public void LoadFile()
        {
            try
            {
                if (!File.Exists(LogPath)) return;

                string[] lines = File.ReadAllLines(LogPath);
                if (lines.Length >= 2 &&
                    decimal.TryParse(lines[0], out decimal total) &&
                    decimal.TryParse(lines[1], out decimal next))
                {
                    // Clamp to control ranges (NumericUpDown has min/max set in designer)
                    VoteTotalNUD.Value = Clamp(total, VoteTotalNUD.Minimum, VoteTotalNUD.Maximum);
                    NextLevelNUD.Value = Clamp(next, NextLevelNUD.Minimum, NextLevelNUD.Maximum);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"LoadFile failed: {ex.Message}");
                // Silent failure is acceptable on load - will use default values
            }
        }

        /// <summary>
        /// Periodically saves vote statistics to disk (triggered by timer).
        /// </summary>
        private void SaveFile_Tick(object sender, EventArgs e)
        {
            try
            {
                // Write atomically by writing all lines at once
                File.WriteAllLines(LogPath, new[]
                {
                    VoteTotalNUD.Value.ToString(),
                    NextLevelNUD.Value.ToString()
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"SaveFile failed: {ex.Message}");
                // Silent failure on auto-save to avoid interrupting user experience
            }
        }

        /// <summary>
        /// Clamps a value between a minimum and maximum.
        /// </summary>
        private static decimal Clamp(decimal value, decimal min, decimal max)
        {
            return Math.Min(Math.Max(min, value), max);
        }

        //end class, kick some ass
    }  //end namespace, rearrange their face
}