using System;
using System.Windows.Forms;

namespace VoteCraft
{
    public partial class Form1 : Form
    {
        string[] SiteName = new string[6];
        string[] SiteURL = new string[6];
        
        public Form1()
        {
            InitializeComponent();
            Clipboard.SetText("HiTechCharles");  //set clipboard with MC user name
            decimal diff = (NextLevelNUD.Value - VoteTotalNUD.Value) / 5;
            decimal RUP = Math.Round(diff, 0, MidpointRounding.AwayFromZero);
            DaysTB.Text = RUP.ToString();


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
        private void Site6BTN_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start(SiteURL[5]);
        }
        #endregion

        private void VoteTotalNUD_ValueChanged(object sender, System.EventArgs e)
        {
            decimal diff = ( NextLevelNUD.Value - VoteTotalNUD.Value) /5;
            decimal RUP = Math.Round(diff, 0, MidpointRounding.AwayFromZero);
            DaysTB.Text = RUP.ToString();
        }

        private void NextLevelNUD_ValueChanged(object sender, System.EventArgs e)
        {
            decimal diff = (NextLevelNUD.Value - VoteTotalNUD.Value) / 5;
            decimal RUP = Math.Round(diff, 0, MidpointRounding.AwayFromZero);
            DaysTB.Text = RUP.ToString();
        }
    }
}