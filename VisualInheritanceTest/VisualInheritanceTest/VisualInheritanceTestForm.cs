//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - Visual Inheritance Test

using System;
using System.Windows.Forms;

namespace VisualInheritanceTest
{

   public partial class VisualInheritanceTestForm : VisualInheritanceBase.VisualInheritanceBaseForm
   {
      public VisualInheritanceTestForm()
      {
         InitializeComponent();
      } 

      private void aboutButton_Click(object sender, EventArgs e)
      {
         MessageBox.Show("This program was created by Deitel & Associates.", "About This Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
      } 
   }
}
