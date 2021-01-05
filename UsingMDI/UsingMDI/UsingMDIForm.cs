//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - Using MDI

using System;
using System.Windows.Forms;

namespace UsingMDI
{
   
   public partial class UsingMDIForm : Form
   {
     
      public UsingMDIForm()
      {
         InitializeComponent();
      }

     
      private void lavenderToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var child = new ChildForm("Lavender Flowers", "lavenderflowers");
         child.MdiParent = this;   
         child.Show();              
      }

      private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
      {

         var child = new ChildForm("Purple Flowers", "purpleflowers");
         child.MdiParent = this;  
         child.Show();          
      }

      private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var child = new ChildForm("Yellow Flowers", "yellowflowers");
         child.MdiParent = this;
         child.Show();        
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.Cascade);
      }

      private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileHorizontal);
      }

      private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
      {
         this.LayoutMdi(MdiLayout.TileVertical);
      }

    }
}
