using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bt_InterfaceTest_Click(object sender, EventArgs e)
        {
            InterfaceTestForm interfaceTestForm = new InterfaceTestForm();
            interfaceTestForm.Show();
        }
    }
}
