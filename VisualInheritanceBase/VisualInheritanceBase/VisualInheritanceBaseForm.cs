//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - Visual Inheritance Base

using System;
using System.Windows.Forms;

namespace VisualInheritanceBase
{
   public partial class VisualInheritanceBaseForm : Form
   {

      public VisualInheritanceBaseForm()
      {
         InitializeComponent();
      }

      private void learnMoreButton_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Bugs, Bugs, Bugs is a product of deitel.com", "Learn More", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
   }
}
