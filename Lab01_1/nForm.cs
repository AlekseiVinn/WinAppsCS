using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab01_1
{
    public partial class nForm : Form
    {
        private bool nClose = false;
        
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }

        //не работает - на закрытии окна сюда не заходит
        //в nForm.Designer.cs закоментировал внутренности в
        //protected override void Dispose(bool disposing)
        //и засунул в него метод Hide();
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        //метод из stackoverflow для выявления, какой метод вывляется призакрытии
        /*protected override void DestroyHandle()
        {
            System.Diagnostics.Debugger.Break();
            base.DestroyHandle();
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _ = this.checkboxClose.Checked ? nClose = true : nClose = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nClose = true;
            Close();
        }
    }
}
