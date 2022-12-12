using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            this.main_num_label.ResetText();
            this.first_num_label.ResetText();
            this.operator_label.ResetText();    
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "0";
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text+  "1";
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "3";
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "5";
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "6";
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "7";
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "8";
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + "9";
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "x";
            if (this.main_num_label.Text != "" )
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
           
            this.main_num_label.Text = "";
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "-";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            this.main_num_label.Text = "";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "+";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            this.main_num_label.Text = "";
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            this.operator_label.Text = "/";
            if (this.main_num_label.Text != "")
            {
                this.first_num_label.Text = this.main_num_label.Text;
            }
            this.main_num_label.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            double fn, sn, r;
            double.TryParse(this.first_num_label.Text, out fn);
            double.TryParse(this.main_num_label.Text, out sn);
            r = 0;
            if (this.operator_label.Text=="+")
            {
                r = fn + sn;
            }

            if (this.operator_label.Text == "-")
            {
                r = fn - sn;
            }

            if (this.operator_label.Text == "x")
            {
                r = fn * sn;
            }

            if (this.operator_label.Text == "/")
            {
                r = fn / sn;
            }
            this.main_num_label.Text= r.ToString();
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            this.main_num_label.Text = this.main_num_label.Text + ".";
        }
    }
}
