using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSPROJECT
{
    public partial class option : Form
    {
        public option()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_prevsnon_Click(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
          calPreemp calPreemp = new calPreemp();
            calPreemp.Show();
        }

        private void btn_nonpreemp_Click(object sender, EventArgs e)
        {
            calNonPreemp cal2 = new calNonPreemp();
            cal2.Show();
        }
    }
}
