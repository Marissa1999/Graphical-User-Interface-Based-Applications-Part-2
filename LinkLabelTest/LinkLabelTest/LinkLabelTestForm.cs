//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - LinkLabel Test

using System.Windows.Forms;

namespace LinkLabelTest
{
    public partial class LinkLabelTestForm : Form
    {
        public LinkLabelTestForm()
        {
            InitializeComponent();
        }

        private void driveLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            driveLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void deitelLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deitelLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void notepadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            notepadLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");

        }

        private void vanierLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            vanierLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.vaniercollege.qc.ca/");
        }
    }
}
