using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_2311104058
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void getNameBtn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.ToString();
            MessageBox.Show(name);
        }
    }
}
