using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pole_Position
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] us = new string[10];
            string[] pas = new string[10];

            string usu;
            string pass;

            usu = textBox1.Text;
            pass = textBox2.Text;

            us[1] = "EdderMejia";
            pas[1] = "emejia";

            us[2] = "Admin";
            pas[2] = "Admin";

            us[3] = "JulioEscobar";
            pas[3] = "1234";

            us[4] = "Giovani";
            pas[4] = "1234";

            Form1 g = new Form1();
            this.Hide();
            

            if (usu == us[1] && pass == pas[1])
            {
                Bienvenido h = new Bienvenido();
                h.ShowDialog();

                SuperUsuario a = new SuperUsuario();
                a.ShowDialog();
            }

            if (usu == us[2] && pass == pas[2])
            {
                Bienvenido h = new Bienvenido();
                h.ShowDialog();

                Admin b = new Admin();
                b.ShowDialog();
            }

            else if (usu == us[3] && pass == pas[3])
            {
                Bienvenido h = new Bienvenido();
                h.ShowDialog();

                Usuario c = new Usuario();
                c.ShowDialog();
            }

            else if (usu == us[4] && pass == pas[4])
            {
                Bienvenido h = new Bienvenido();
                h.ShowDialog();

                Usuario d = new Usuario();
                d.ShowDialog();
            }

            else
            {
                Error_131 f = new Error_131();
                f.ShowDialog();
                textBox1.Text = "";
                textBox2.Text = "";
            }

            g.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
