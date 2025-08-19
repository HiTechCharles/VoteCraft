using System;
using System.Windows.Forms;
using System.IO;

namespace VoteCraft
{
    public partial class Form1 : Form
    {
        readonly string[] SiteName = new string[6];  //name of web sites
        readonly string[] SiteURL = new string[6];   //site url
        public static string CatPath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\VoteCraft\\";
        public static string LogPath = @CatPath + "VoteStats.txt";

        public Form1()
        {
            InitializeComponent();
            Clipboard.SetText("HiTechCharles");  //set clipboard with MC user name
            LoadFile();
            UpdateToGo();

            #region Site Definitions and button text
            SiteURL[0] = "http://topminecraftservers.org/vote/4613";
            SiteName[0] = "Top MineCraft Servers";
            Site1BTN.Text = SiteName[0];

            SiteURL[1] = "https://minecraftservers.org/vote/525699";
            SiteName[1] = "MineCraft Servers.org";
            Site2BTN.Text = SiteName[1];

            SiteURL[2] = "https://minecraft-server-list.com/server/434154/vote/";
            SiteName[2] = "MineCraft Server List";
            Site3BTN.Text = SiteName[2];

            SiteURL[3] = "https://minecraft-mp.com/server/211256/vote/";
            SiteName[3] = "Minecraft MP";
            Site4BTN.Text = SiteName[3];

            SiteURL[4] = "https://minecraft.buzz/vote/7051";
            SiteName[4] = "Minecraft Buzz";
            Site5BTN.Text = SiteName[4];

            SiteName[5] = "MC Java Wiki";
            SiteURL[5] = "https://minecraft.fandom.com/wiki/Java_Edition";
            WikiBTN.Text = SiteName[5];
            #endregion

            Directory.CreateDirectory(CatPath);
        }

        #region Site Buttons
        private void Site1BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[0]);
            Site1BTN.BackColor = System.Drawing.Color.Red;
        }
        private void Site2BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[1]);
            Site2BTN.BackColor = System.Drawing.Color.Red;
        }
        private void Site3BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[2]);
            Site3BTN.BackColor = System.Drawing.Color.Red;
        }
        private void Site4BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[3]);
            Site4BTN.BackColor = System.Drawing.Color.Red;
        }
        private void Site5BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[4]);
            Site5BTN.BackColor = System.Drawing.Color.Red;
        }

        private void WikiBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[5]);
        }
        #endregion

        private void UpdateToGo()
        {
            DateTime CurrentDate = DateTime.Now;  //get current date
            decimal diff = (NextLevelNUD.Value - VoteTotalNUD.Value) / 5;  //get difference between current total and next level total
            decimal RUP = Math.Round(diff, 0, MidpointRounding.AwayFromZero);  //round up number of days between
            DateTime NewDate = CurrentDate.AddDays(Convert.ToDouble(RUP));  //add days to current date
            DaysTB.Text = RUP.ToString() + "   " + NewDate.ToShortDateString();  //write to text box number of days and date
        }

        #region Numeric UpDown Value Changed
        private void VoteTotalNUD_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateToGo();
        }

        private void NextLevelNUD_ValueChanged(object sender, System.EventArgs e)
        {
            UpdateToGo();
        }
        #endregion

        public void LoadFile()
        {
            if ( File.Exists(LogPath) == true )
            {
                StreamReader VC = new StreamReader(@LogPath);
                VoteTotalNUD.Value = Convert.ToDecimal(VC.ReadLine());
                NextLevelNUD.Value = Convert.ToDecimal(VC.ReadLine());
                VC.Close();
            }

        }

        private void SaveFile_Tick(object sender, EventArgs e)
        {
            StreamWriter VC = new System.IO.StreamWriter(LogPath);
            VC.WriteLine(VoteTotalNUD.Value.ToString());
            VC.WriteLine(NextLevelNUD.Value.ToString());
            VC.Close();
        }

        //end class, kick some ass
    }  //end namespace, rearrange their face
}