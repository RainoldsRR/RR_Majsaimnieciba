using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_Majsaimnieciba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox_ienakumi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_aprekinat_Click(object sender, EventArgs e)
        {
            double ienakumi = Convert.ToDouble(txtbox_ienakumi1.Text);
            double ienakumi1 = Convert.ToDouble(txtbox_ienakumi2.Text);
            double izdevumi = Convert.ToDouble(txtbox_izdevumi1);
            double izdevumi1 = Convert.ToDouble(txtbox_izdevumi2);
            double izdevumi2 = Convert.ToDouble(txtbox_izdevumi3);
            double izdevumi3 = Convert.ToDouble(txtbox_izdevumi4);

            majsm_budzets(ienakumi, ienakumi1, izdevumi, izdevumi1, izdevumi2, izdevumi3);
        }

        public void majsm_budzets(double ienakumi_, double ienakumi_1, double izdevumi_, double izdevumi_1, double izdevumi_2, double izdevumi_3)
        {

        }
    }
}
