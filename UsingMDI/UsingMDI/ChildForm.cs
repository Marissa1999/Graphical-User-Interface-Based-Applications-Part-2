//ID: 1775227
//Name: Marissa Goncalves
//Lab 2 - Using MDI

using System.Drawing;
using System.Windows.Forms;

namespace UsingMDI
{
   public partial class ChildForm : Form
   {
      public ChildForm(string title, string resourceName)
      {
      
         InitializeComponent();

         Text = title;

         displayPictureBox.Image = (Image)(Properties.Resources.ResourceManager.GetObject(resourceName));
      }
   }
}

