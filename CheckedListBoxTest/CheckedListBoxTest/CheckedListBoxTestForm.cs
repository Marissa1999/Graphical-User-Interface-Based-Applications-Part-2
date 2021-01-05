//ID: 1775227
//Name: Marissa Goncalves
//Lab 3 - CheckedListBox Test

using System.Windows.Forms;

namespace CheckedListBoxTest
{
    public partial class CheckedListBoxTest : Form
    {
        public CheckedListBoxTest()
        {
            InitializeComponent();
        }

        private void itemCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = itemCheckedListBox.SelectedItem.ToString();

            if(e.NewValue == CheckState.Checked)
            {
                displayListBox.Items.Add(item);
            }

            else
            {
                displayListBox.Items.Remove(item);
            }
        }
       
    }
}
