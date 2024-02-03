using Syncfusion.Licensing;
using Syncfusion.XForms.Buttons;
using Syncfusion.WinForms.Controls;

namespace DietApp.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void SfButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
