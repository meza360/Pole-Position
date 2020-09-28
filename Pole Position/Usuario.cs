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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            #region GroupBoxInvisibles
            groupBox2.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox9.Visible = false;
            #endregion GroupBoxInvisibles 
            #region TextBoxInvisibles
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;
            textBox53.Visible = false;
            textBox54.Visible = false;
            textBox55.Visible = false;
            textBox56.Visible = false;
            textBox57.Visible = false;
            textBox58.Visible = false;
            textBox59.Visible = false;
            textBox60.Visible = false;
            textBox61.Visible = false;
            textBox62.Visible = false;
            textBox63.Visible = false;
            textBox64.Visible = false;
            textBox65.Visible = false;
            textBox66.Visible = false;
            textBox67.Visible = false;
            textBox68.Visible = false;
            textBox69.Visible = false;
            textBox70.Visible = false;
            textBox71.Visible = false;
            textBox72.Visible = false;
            textBox73.Visible = false;
            textBox74.Visible = false;
            textBox75.Visible = false;
            textBox76.Visible = false;
            textBox77.Visible = false;
            textBox78.Visible = false;
            textBox79.Visible = false;
            textBox80.Visible = false;
            textBox81.Visible = false;
            textBox82.Visible = false;
            textBox83.Visible = false;
            textBox84.Visible = false;
            textBox85.Visible = false;
            textBox86.Visible = false;
            textBox87.Visible = false;
            textBox88.Visible = false;
            textBox89.Visible = false;
            textBox90.Visible = false;
            textBox91.Visible = false;
            textBox92.Visible = false;
            textBox93.Visible = false;
            textBox94.Visible = false;
            textBox95.Visible = false;
            textBox96.Visible = false;
            textBox97.Visible = false;
            textBox98.Visible = false;
            textBox99.Visible = false;
            textBox100.Visible = false;




            #endregion TextBoxInvisibles

            button4.Visible = false;
            button5.Visible = false;
            button1.Visible = false;
           
        
            listBox1.Text = "";

        }

        #region GroupBoxVisbles 
        private void checkBox101_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox101.Checked == true)
            {
                groupBox2.Visible = true;
            }
            else
            {
                groupBox2.Visible = false;
            }
        }

        private void checkBox102_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox102.Checked == true)
            {
                groupBox4.Visible = true;
            }
            else
            {
                groupBox4.Visible = false;
            }
        }

        private void checkBox103_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox103.Checked == true)
            {
                groupBox5.Visible = true;
            }
            else
            {
                groupBox5.Visible = false;
            }
        }

        private void checkBox104_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox104.Checked == true)
            {
                groupBox6.Visible = true;
            }
            else
            {
                groupBox6.Visible = false;
            }
        }

        private void checkBox105_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox105.Checked == true)
            {
                groupBox7.Visible = true;
            }
            else
            {
                groupBox7.Visible = false;
            }
        }
        #endregion GroupBoxVisibles

        #region TextBoxVisibles
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Visible = true;
            }
            else
            {
                textBox1.Visible = false;
                textBox1.Text = "";
            }

            if (checkBox1.Checked == true)
            {
                button1.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;
                textBox2.Text = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Visible = true;
            }
            else
            {
                textBox3.Visible = false;
                textBox3.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Visible = true;
            }
            else
            {
                textBox4.Visible = false;
                textBox4.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Visible = true;
            }
            else
            {
                textBox5.Visible = false;
                textBox5.Text = "";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Visible = true;
            }
            else
            {
                textBox6.Visible = false;
                textBox6.Text = "";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Visible = true;
            }
            else
            {
                textBox7.Visible = false;
                textBox7.Text = "";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Visible = true;
            }
            else
            {
                textBox8.Visible = false;
                textBox8.Text = "";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Visible = true;
            }
            else
            {
                textBox9.Visible = false;
                textBox9.Text = "";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Visible = true;
            }
            else
            {
                textBox10.Visible = false;
                textBox10.Text = "";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Visible = true;
            }
            else
            {
                textBox11.Visible = false;
                textBox11.Text = "";
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Visible = true;
            }
            else
            {
                textBox12.Visible = false;
                textBox12.Text = "";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Visible = true;
            }
            else
            {
                textBox13.Visible = false;
                textBox13.Text = "";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Visible = true;
            }
            else
            {
                textBox14.Visible = false;
                textBox14.Text = "";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Visible = true;
            }
            else
            {
                textBox15.Visible = false;
                textBox15.Text = "";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Visible = true;
            }
            else
            {
                textBox16.Visible = false;
                textBox16.Text = "";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox17.Visible = true;
            }
            else
            {
                textBox17.Visible = false;
                textBox17.Text = "";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox18.Visible = true;
            }
            else
            {
                textBox18.Visible = false;
                textBox18.Text = "";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox19.Visible = true;
            }
            else
            {
                textBox19.Visible = false;
                textBox19.Text = "";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox20.Visible = true;
            }
            else
            {
                textBox20.Visible = false;
                textBox20.Text = "";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox21.Visible = true;
            }
            else
            {
                textBox21.Visible = false;
                textBox21.Text = "";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox22.Visible = true;
            }
            else
            {
                textBox22.Visible = false;
                textBox22.Text = "";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox23.Visible = true;
            }
            else
            {
                textBox23.Visible = false;
                textBox23.Text = "";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                textBox24.Visible = true;
            }
            else
            {
                textBox24.Visible = false;
                textBox24.Text = "";
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked == true)
            {
                textBox25.Visible = true;
            }
            else
            {
                textBox25.Visible = false;
                textBox25.Text = "";
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked == true)
            {
                textBox26.Visible = true;
            }
            else
            {
                textBox26.Visible = false;
                textBox26.Text = "";
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked == true)
            {
                textBox27.Visible = true;
            }
            else
            {
                textBox27.Visible = false;
                textBox27.Text = "";
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked == true)
            {
                textBox28.Visible = true;
            }
            else
            {
                textBox28.Visible = false;
                textBox28.Text = "";
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked == true)
            {
                textBox29.Visible = true;
            }
            else
            {
                textBox29.Visible = false;
                textBox29.Text = "";
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked == true)
            {
                textBox30.Visible = true;
            }
            else
            {
                textBox30.Visible = false;
                textBox30.Text = "";
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked == true)
            {
                textBox31.Visible = true;
            }
            else
            {
                textBox31.Visible = false;
                textBox31.Text = "";
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked == true)
            {
                textBox32.Visible = true;
            }
            else
            {
                textBox32.Visible = false;
                textBox32.Text = "";
            }
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked == true)
            {
                textBox33.Visible = true;
            }
            else
            {
                textBox33.Visible = false;
                textBox33.Text = "";
            }
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked == true)
            {
                textBox34.Visible = true;
            }
            else
            {
                textBox34.Visible = false;
                textBox34.Text = "";
            }
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked == true)
            {
                textBox35.Visible = true;
            }
            else
            {
                textBox35.Visible = false;
                textBox35.Text = "";
            }
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked == true)
            {
                textBox36.Visible = true;
            }
            else
            {
                textBox36.Visible = false;
                textBox36.Text = "";
            }
        }

        private void checkBox37_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox37.Checked == true)
            {
                textBox37.Visible = true;
            }
            else
            {
                textBox37.Visible = false;
                textBox37.Text = "";
            }
        }

        private void checkBox38_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox38.Checked == true)
            {
                textBox38.Visible = true;
            }
            else
            {
                textBox38.Visible = false;
                textBox38.Text = "";
            }
        }

        private void checkBox39_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox39.Checked == true)
            {
                textBox39.Visible = true;
            }
            else
            {
                textBox39.Visible = false;
                textBox39.Text = "";
            }
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked == true)
            {
                textBox40.Visible = true;
            }
            else
            {
                textBox40.Visible = false;
                textBox40.Text = "";
            }
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked == true)
            {
                textBox41.Visible = true;
            }
            else
            {
                textBox41.Visible = false;
                textBox41.Text = "";
            }
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked == true)
            {
                textBox42.Visible = true;
            }
            else
            {
                textBox42.Visible = false;
                textBox42.Text = "";
            }
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked == true)
            {
                textBox43.Visible = true;
            }
            else
            {
                textBox43.Visible = false;
                textBox43.Text = "";
            }
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked == true)
            {
                textBox44.Visible = true;
            }
            else
            {
                textBox44.Visible = false;
                textBox44.Text = "";
            }
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked == true)
            {
                textBox45.Visible = true;
            }
            else
            {
                textBox45.Visible = false;
                textBox45.Text = "";
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked == true)
            {
                textBox46.Visible = true;
            }
            else
            {
                textBox46.Visible = false;
                textBox46.Text = "";
            }
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked == true)
            {
                textBox47.Visible = true;
            }
            else
            {
                textBox47.Visible = false;
                textBox47.Text = "";
            }
        }

        private void checkBox48_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox48.Checked == true)
            {
                textBox48.Visible = true;
            }
            else
            {
                textBox48.Visible = false;
                textBox48.Text = "";
            }
        }

        private void checkBox49_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox49.Checked == true)
            {
                textBox49.Visible = true;
            }
            else
            {
                textBox49.Visible = false;
                textBox49.Text = "";
            }
        }

        private void checkBox50_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox50.Checked == true)
            {
                textBox50.Visible = true;
            }
            else
            {
                textBox50.Visible = false;
                textBox50.Text = "";
            }
        }

        private void checkBox51_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox51.Checked == true)
            {
                textBox51.Visible = true;
            }
            else
            {
                textBox51.Visible = false;
                textBox51.Text = "";
            }
        }

        private void checkBox52_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox52.Checked == true)
            {
                textBox52.Visible = true;
            }
            else
            {
                textBox52.Visible = false;
                textBox52.Text = "";
            }
        }

        private void checkBox53_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox53.Checked == true)
            {
                textBox53.Visible = true;
            }
            else
            {
                textBox53.Visible = false;
                textBox53.Text = "";
            }
        }

        private void checkBox54_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox54.Checked == true)
            {
                textBox54.Visible = true;
            }
            else
            {
                textBox54.Visible = false;
                textBox54.Text = "";
            }
        }

        private void checkBox55_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox55.Checked == true)
            {
                textBox55.Visible = true;
            }
            else
            {
                textBox55.Visible = false;
                textBox55.Text = "";
            }
        }

        private void checkBox56_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox56.Checked == true)
            {
                textBox56.Visible = true;
            }
            else
            {
                textBox56.Visible = false;
                textBox56.Text = "";
            }
        }

        private void checkBox57_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox57.Checked == true)
            {
                textBox57.Visible = true;
            }
            else
            {
                textBox57.Visible = false;
                textBox57.Text = "";
            }
        }

        private void checkBox58_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox58.Checked == true)
            {
                textBox58.Visible = true;
            }
            else
            {
                textBox58.Visible = false;
                textBox58.Text = "";
            }
        }

        private void checkBox59_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox59.Checked == true)
            {
                textBox59.Visible = true;
            }
            else
            {
                textBox59.Visible = false;
                textBox59.Text = "";
            }
        }

        private void checkBox60_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox60.Checked == true)
            {
                textBox60.Visible = true;
            }
            else
            {
                textBox60.Visible = false;
                textBox60.Text = "";
            }
        }

        private void checkBox61_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox61.Checked == true)
            {
                textBox61.Visible = true;
            }
            else
            {
                textBox61.Visible = false;
                textBox61.Text = "";
            }
        }

        private void checkBox62_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox62.Checked == true)
            {
                textBox62.Visible = true;
            }
            else
            {
                textBox62.Visible = false;
                textBox62.Text = "";
            }
        }

        private void checkBox63_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox63.Checked == true)
            {
                textBox63.Visible = true;
            }
            else
            {
                textBox63.Visible = false;
                textBox63.Text = "";
            }
        }

        private void checkBox64_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox64.Checked == true)
            {
                textBox64.Visible = true;
            }
            else
            {
                textBox64.Visible = false;
                textBox64.Text = "";
            }
        }

        private void checkBox65_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox65.Checked == true)
            {
                textBox65.Visible = true;
            }
            else
            {
                textBox65.Visible = false;
                textBox65.Text = "";
            }
        }

        private void checkBox66_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox66.Checked == true)
            {
                textBox66.Visible = true;
            }
            else
            {
                textBox66.Visible = false;
                textBox66.Text = "";
            }
        }

        private void checkBox67_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox67.Checked == true)
            {
                textBox67.Visible = true;
            }
            else
            {
                textBox67.Visible = false;
                textBox67.Text = "";
            }
        }

        private void checkBox68_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox68.Checked == true)
            {
                textBox68.Visible = true;
            }
            else
            {
                textBox68.Visible = false;
                textBox68.Text = "";
            }
        }

        private void checkBox69_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox69.Checked == true)
            {
                textBox69.Visible = true;
            }
            else
            {
                textBox69.Visible = false;
                textBox69.Text = "";
            }
        }

        private void checkBox70_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox70.Checked == true)
            {
                textBox70.Visible = true;
            }
            else
            {
                textBox70.Visible = false;
                textBox70.Text = "";
            }
        }

        private void checkBox71_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox71.Checked == true)
            {
                textBox71.Visible = true;
            }
            else
            {
                textBox71.Visible = false;
                textBox71.Text = "";
            }
        }

        private void checkBox72_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox72.Checked == true)
            {
                textBox72.Visible = true;
            }
            else
            {
                textBox72.Visible = false;
                textBox72.Text = "";
            }
        }

        private void checkBox73_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox73.Checked == true)
            {
                textBox73.Visible = true;
            }
            else
            {
                textBox73.Visible = false;
                textBox73.Text = "";
            }
        }

        private void checkBox74_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox74.Checked == true)
            {
                textBox74.Visible = true;
            }
            else
            {
                textBox74.Visible = false;
                textBox74.Text = "";
            }
        }

        private void checkBox75_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox75.Checked == true)
            {
                textBox75.Visible = true;
            }
            else
            {
                textBox75.Visible = false;
                textBox75.Text = "";
            }
        }

        private void checkBox76_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox76.Checked == true)
            {
                textBox76.Visible = true;
            }
            else
            {
                textBox76.Visible = false;
                textBox76.Text = "";
            }
        }

        private void checkBox77_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox77.Checked == true)
            {
                textBox77.Visible = true;
            }
            else
            {
                textBox77.Visible = false;
                textBox77.Text = "";
            }
        }

        private void checkBox78_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox78.Checked == true)
            {
                textBox78.Visible = true;
            }
            else
            {
                textBox78.Visible = false;
                textBox78.Text = "";
            }
        }

        private void checkBox79_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox79.Checked == true)
            {
                textBox79.Visible = true;
            }
            else
            {
                textBox79.Visible = false;
                textBox79.Text = "";
            }
        }

        private void checkBox80_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox80.Checked == true)
            {
                textBox80.Visible = true;
            }
            else
            {
                textBox80.Visible = false;
                textBox80.Text = "";
            }
        }

        private void checkBox81_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox81.Checked == true)
            {
                textBox81.Visible = true;
            }
            else
            {
                textBox81.Visible = false;
                textBox81.Text = "";
            }
        }

        private void checkBox82_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox82.Checked == true)
            {
                textBox82.Visible = true;
            }
            else
            {
                textBox82.Visible = false;
                textBox82.Text = "";
            }
        }

        private void checkBox83_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox83.Checked == true)
            {
                textBox83.Visible = true;
            }
            else
            {
                textBox83.Visible = false;
                textBox83.Text = "";
            }
        }

        private void checkBox84_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox84.Checked == true)
            {
                textBox84.Visible = true;
            }
            else
            {
                textBox84.Visible = false;
                textBox84.Text = "";
            }
        }

        private void checkBox85_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox85.Checked == true)
            {
                textBox85.Visible = true;
            }
            else
            {
                textBox85.Visible = false;
                textBox85.Text = "";
            }
        }

        private void checkBox86_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox86.Checked == true)
            {
                textBox86.Visible = true;
            }
            else
            {
                textBox86.Visible = false;
                textBox86.Text = "";
            }
        }

        private void checkBox87_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox87.Checked == true)
            {
                textBox87.Visible = true;
            }
            else
            {
                textBox87.Visible = false;
                textBox87.Text = "";
            }
        }

        private void checkBox88_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox88.Checked == true)
            {
                textBox88.Visible = true;
            }
            else
            {
                textBox88.Visible = false;
                textBox88.Text = "";
            }
        }

        private void checkBox89_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox89.Checked == true)
            {
                textBox89.Visible = true;
            }
            else
            {
                textBox89.Visible = false;
                textBox89.Text = "";
            }
        }

        private void checkBox90_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox90.Checked == true)
            {
                textBox90.Visible = true;
            }
            else
            {
                textBox90.Visible = false;
                textBox90.Text = "";
            }
        }

        private void checkBox91_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox91.Checked == true)
            {
                textBox91.Visible = true;
            }
            else
            {
                textBox91.Visible = false;
                textBox91.Text = "";
            }
        }

        private void checkBox92_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox92.Checked == true)
            {
                textBox92.Visible = true;
            }
            else
            {
                textBox92.Visible = false;
                textBox92.Text = "";
            }
        }

        private void checkBox93_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox93.Checked == true)
            {
                textBox93.Visible = true;
            }
            else
            {
                textBox93.Visible = false;
                textBox93.Text = "";
            }
        }

        private void checkBox94_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox94.Checked == true)
            {
                textBox94.Visible = true;
            }
            else
            {
                textBox94.Visible = false;
                textBox94.Text = "";
            }
        }

        private void checkBox95_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox95.Checked == true)
            {
                textBox95.Visible = true;
            }
            else
            {
                textBox95.Visible = false;
                textBox95.Text = "";
            }
        }

        private void checkBox96_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox96.Checked == true)
            {
                textBox96.Visible = true;
            }
            else
            {
                textBox96.Visible = false;
                textBox96.Text = "";
            }
        }

        private void checkBox97_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox97.Checked == true)
            {
                textBox97.Visible = true;
            }
            else
            {
                textBox97.Visible = false;
                textBox97.Text = "";
            }
        }

        private void checkBox98_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox98.Checked == true)
            {
                textBox98.Visible = true;
            }
            else
            {
                textBox98.Visible = false;
                textBox98.Text = "";
            }
        }

        private void checkBox99_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox99.Checked == true)
            {
                textBox99.Visible = true;
            }
            else
            {
                textBox99.Visible = false;
                textBox99.Text = "";
            }
        }

        private void checkBox100_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox100.Checked == true)
            {
                textBox100.Visible = true;
            }
            else
            {
                textBox100.Visible = false;
                textBox100.Text = "";
            }
        }
        #endregion TextBoxVisibles
        #region Botones
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = false;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario x = new Usuario();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuario x = new Usuario();
            this.Hide();
            x.ShowDialog();
        }
        #endregion Botones

        string[] op = new string[150];
        int[] precio = new int[150];
        int[] cantidad = new int[150];
        int[] subtotal = new int[150];

        #region PreciosFactura
        public void PreciosOP1()
        {
            #region PreciosOP1
            op[1] = "Cerveza      "; precio[1] = 20;
            op[2] = "Ron          "; precio[2] = 25;
            op[3] = "Vino         "; precio[3] = 35;
            op[4] = "Vodka        "; precio[4] = 25;
            op[5] = "Whisky       "; precio[5] = 30;
            op[6] = "Tequila      "; precio[6] = 35;
            op[7] = "Caña         "; precio[7] = 15;
            op[8] = "Brandy       "; precio[8] = 30;
            op[9] = "Coñac        "; precio[9] = 45;
            op[10] = "Mezcal       "; precio[10] = 30;
            op[11] = "Piña Colada  "; precio[11] = 15;
            op[12] = "Margarita    "; precio[12] = 20;
            op[13] = "Michelada    "; precio[13] = 20;
            op[14] = "Sidra        "; precio[14] = 15;
            op[15] = "Champange    "; precio[15] = 25;
            op[16] = "Pulique      "; precio[16] = 20;
            op[17] = "Pisco        "; precio[17] = 25;
            op[18] = "Casillero    "; precio[18] = 30;
            op[19] = "Cocuy        "; precio[19] = 20;
            op[20] = "Grappa       "; precio[20] = 25;
            #endregion PreciosOP1
        }

        public void PreciosOP2()
        {
            #region PreciosOP2
            op[21] = "Cafe 8onz    "; precio[21] = 08;
            op[22] = "Cafe 12onz   "; precio[22] = 12;
            op[23] = "Cafe 16onz   "; precio[23] = 14;
            op[24] = "Capuchino    "; precio[24] = 18;
            op[25] = "Chocolate    "; precio[25] = 20;
            op[26] = "Chocolate C/L"; precio[26] = 25;
            op[27] = "Té           "; precio[27] = 10;
            op[28] = "Ponche       "; precio[28] = 16;
            op[29] = "Campurrado   "; precio[29] = 25;
            op[30] = "Sidra        "; precio[30] = 25;
            op[31] = "Chocolate Bla"; precio[31] = 25;
            op[32] = "Atol De Coco "; precio[32] = 30;
            op[33] = "Cafe Irlandés"; precio[33] = 27;
            op[34] = "Avena        "; precio[34] = 18;
            op[35] = "Vino Caliente"; precio[35] = 24;
            op[36] = "Arroz C/L    "; precio[36] = 25;
            op[37] = "Té De Manzana"; precio[37] = 15;
            op[38] = "Cacao        "; precio[38] = 20;
            op[39] = "Canela       "; precio[39] = 18;
            op[40] = "Sidra De Nar "; precio[40] = 25;
            #endregion PreciosOP2
        }

        public void PreciosOP3()
        {
            #region PreciosOP3
            op[41] = "Banano       "; precio[41] = 15;
            op[42] = "Piña         "; precio[42] = 15;
            op[43] = "Sandia       "; precio[43] = 15;
            op[44] = "Avena        "; precio[44] = 15;
            op[45] = "Naranja      "; precio[45] = 15;
            op[46] = "Vainilla     "; precio[46] = 15;
            op[47] = "Zanahoria    "; precio[47] = 15;
            op[48] = "Fresa        "; precio[48] = 15;
            op[49] = "Papaya       "; precio[49] = 15;
            op[50] = "Pera         "; precio[50] = 15;
            op[51] = "Melon        "; precio[51] = 15;
            op[52] = "Batidos      "; precio[52] = 15;
            op[53] = "Carambola    "; precio[53] = 15;
            op[54] = "Cerales      "; precio[54] = 15;
            op[55] = "Oreos        "; precio[55] = 15;
            op[56] = "Durazno      "; precio[56] = 15;
            op[57] = "Manzana      "; precio[57] = 15;
            op[58] = "Chocolate    "; precio[58] = 15;
            op[59] = "Mezclas      "; precio[59] = 20;
            op[60] = "Multifruta   "; precio[60] = 30;
            #endregion PreciosOP3

        }

        public void PreciosOP4()
        {
            #region PreciosOP4
            op[61] = "Limonada     "; precio[61] = 10;
            op[62] = "Naranjada    "; precio[62] = 12;
            op[63] = "Sandia       "; precio[63] = 15;
            op[64] = "Melon        "; precio[64] = 17;
            op[65] = "Horchata     "; precio[65] = 20;
            op[66] = "Maizena      "; precio[66] = 15;
            op[67] = "Jamaica      "; precio[67] = 17;
            op[68] = "Tilo         "; precio[68] = 14;
            op[69] = "Tamarindo    "; precio[69] = 20;
            op[70] = "Chilacayote  "; precio[70] = 20;
            op[71] = "Coca-Cola    "; precio[71] = 10;
            op[72] = "Pepsi        "; precio[72] = 08;
            op[73] = "Rica Piña    "; precio[73] = 10;
            op[74] = "Rica Roja    "; precio[74] = 10;
            op[75] = "Rica Sandia  "; precio[75] = 10;
            op[76] = "Rica Manzana "; precio[76] = 10;
            op[77] = "Mora Azul    "; precio[77] = 08;
            op[78] = "Grappete     "; precio[78] = 10;
            op[79] = "Te Frio      "; precio[79] = 18;
            op[80] = "Red Bull     "; precio[80] = 25;
            #endregion PreciosOP
        }

        public void PreciosOP5()
        {
            #region PreciosOP5
            op[81] = "Nachos       "; precio[81] = 10;
            op[82] = "Manias       "; precio[82] = 05;
            op[83] = "Tostadas     "; precio[83] = 08;
            op[84] = "Aros Cebolla "; precio[84] = 15;
            op[85] = "Rollitos     "; precio[85] = 20;
            op[86] = "Mixtas       "; precio[86] = 25;
            op[87] = "Wraps Pollo  "; precio[87] = 30;
            op[88] = "Wraps Jamon  "; precio[88] = 30;
            op[89] = "Pie          "; precio[89] = 15;
            op[90] = "Camaron      "; precio[90] = 40;
            op[91] = "Alitas       "; precio[91] = 30;
            op[92] = "Shushi       "; precio[92] = 50;
            op[93] = "Pepino C/Atun"; precio[93] = 25;
            op[94] = "Galletas     "; precio[94] = 10;
            op[95] = "Rollitos Toci"; precio[95] = 15;
            op[96] = "Salchicha Bar"; precio[96] = 15;
            op[97] = "Salchicha Loc"; precio[97] = 10;
            op[98] = "Choripapas   "; precio[98] = 25;
            op[99] = "Salchipapas  "; precio[99] = 20;
            op[100] = "Papas Fritas "; precio[100] = 10;
            #endregion PreciosOP5
        }

        #endregion PreciosFactura

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            try
            {
                if (checkBox101.Checked == true)
                {
                    PreciosOP1();
                    #region TextBox1
                    if (textBox1.Text != "")
                    {
                        int temp = int.Parse(textBox1.Text);
                        cantidad[1] = temp;
                        subtotal[1] = precio[1] * cantidad[1];
                        total = total + subtotal[1];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[1] = temp;
                        subtotal[1] = precio[1] * cantidad[1];
                        total = total + subtotal[1];
                    }
                    #endregion TextBox1
                    #region TextBox2
                    if (textBox2.Text != "")
                    {
                        int temp = int.Parse(textBox2.Text);
                        cantidad[2] = temp;
                        subtotal[2] = precio[2] * cantidad[2];
                        total = total + subtotal[2];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[2] = temp;
                        subtotal[2] = precio[2] * cantidad[2];
                        total = total + subtotal[2];
                    }
                    #endregion TextBox2
                    #region TextBox3
                    if (textBox3.Text != "")
                    {
                        int temp = int.Parse(textBox3.Text);
                        cantidad[3] = temp;
                        subtotal[3] = precio[3] * cantidad[3];
                        total = total + subtotal[3];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[3] = temp;
                        subtotal[3] = precio[3] * cantidad[3];
                        total = total + subtotal[3];
                    }
                    #endregion TextBox3
                    #region TextBox4
                    if (textBox4.Text != "")
                    {
                        int temp = int.Parse(textBox4.Text);
                        cantidad[4] = temp;
                        subtotal[4] = precio[4] * cantidad[4];
                        total = total + subtotal[4];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[4] = temp;
                        subtotal[4] = precio[4] * cantidad[4];
                        total = total + subtotal[4];
                    }
                    #endregion TextBox4
                    #region TextBox5
                    if (textBox5.Text != "")
                    {
                        int temp = int.Parse(textBox5.Text);
                        cantidad[5] = temp;
                        subtotal[5] = precio[5] * cantidad[5];
                        total = total + subtotal[5];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[5] = temp;
                        subtotal[5] = precio[5] * cantidad[5];
                        total = total + subtotal[5];
                    }
                    #endregion TextBox5
                    #region TextBox6
                    if (textBox6.Text != "")
                    {
                        int temp = int.Parse(textBox6.Text);
                        cantidad[6] = temp;
                        subtotal[6] = precio[6] * cantidad[6];
                        total = total + subtotal[6];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[6] = temp;
                        subtotal[6] = precio[6] * cantidad[6];
                        total = total + subtotal[6];
                    }
                    #endregion TextBox6
                    #region TextBox7
                    if (textBox7.Text != "")
                    {
                        int temp = int.Parse(textBox7.Text);
                        cantidad[7] = temp;
                        subtotal[7] = precio[7] * cantidad[7];
                        total = total + subtotal[7];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[7] = temp;
                        subtotal[7] = precio[7] * cantidad[7];
                        total = total + subtotal[7];
                    }
                    #endregion TextBox7
                    #region TextBox8
                    if (textBox8.Text != "")
                    {
                        int temp = int.Parse(textBox8.Text);
                        cantidad[8] = temp;
                        subtotal[8] = precio[8] * cantidad[8];
                        total = total + subtotal[8];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[8] = temp;
                        subtotal[8] = precio[8] * cantidad[8];
                        total = total + subtotal[8];
                    }
                    #endregion TextBox8
                    #region TextBox9
                    if (textBox9.Text != "")
                    {
                        int temp = int.Parse(textBox9.Text);
                        cantidad[9] = temp;
                        subtotal[9] = precio[9] * cantidad[9];
                        total = total + subtotal[9];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[9] = temp;
                        subtotal[9] = precio[9] * cantidad[9];
                        total = total + subtotal[9];
                    }
                    #endregion TextBox9
                    #region TextBox10
                    if (textBox10.Text != "")
                    {
                        int temp = int.Parse(textBox10.Text);
                        cantidad[10] = temp;
                        subtotal[10] = precio[10] * cantidad[10];
                        total = total + subtotal[10];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[10] = temp;
                        subtotal[10] = precio[10] * cantidad[10];
                        total = total + subtotal[10];
                    }
                    #endregion TextBox10
                    #region TextBox11
                    if (textBox11.Text != "")
                    {
                        int temp = int.Parse(textBox11.Text);
                        cantidad[11] = temp;
                        subtotal[11] = precio[11] * cantidad[11];
                        total = total + subtotal[11];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[11] = temp;
                        subtotal[11] = precio[11] * cantidad[11];
                        total = total + subtotal[11];
                    }
                    #endregion TextBox11
                    #region TextBox12
                    if (textBox12.Text != "")
                    {
                        int temp = int.Parse(textBox12.Text);
                        cantidad[12] = temp;
                        subtotal[12] = precio[12] * cantidad[12];
                        total = total + subtotal[12];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[12] = temp;
                        subtotal[12] = precio[12] * cantidad[12];
                        total = total + subtotal[12];
                    }
                    #endregion TextBox12
                    #region TextBox13
                    if (textBox13.Text != "")
                    {
                        int temp = int.Parse(textBox13.Text);
                        cantidad[13] = temp;
                        subtotal[13] = precio[13] * cantidad[13];
                        total = total + subtotal[13];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[13] = temp;
                        subtotal[13] = precio[13] * cantidad[13];
                        total = total + subtotal[13];
                    }
                    #endregion TextBox13
                    #region TextBox14
                    if (textBox14.Text != "")
                    {
                        int temp = int.Parse(textBox14.Text);
                        cantidad[14] = temp;
                        subtotal[14] = precio[14] * cantidad[14];
                        total = total + subtotal[14];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[14] = temp;
                        subtotal[14] = precio[14] * cantidad[14];
                        total = total + subtotal[14];
                    }
                    #endregion TextBox14
                    #region TextBox15
                    if (textBox15.Text != "")
                    {
                        int temp = int.Parse(textBox15.Text);
                        cantidad[15] = temp;
                        subtotal[15] = precio[15] * cantidad[15];
                        total = total + subtotal[15];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[15] = temp;
                        subtotal[15] = precio[15] * cantidad[15];
                        total = total + subtotal[15];
                    }
                    #endregion TextBox15
                    #region TextBox16
                    if (textBox16.Text != "")
                    {
                        int temp = int.Parse(textBox16.Text);
                        cantidad[16] = temp;
                        subtotal[16] = precio[16] * cantidad[16];
                        total = total + subtotal[16];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[16] = temp;
                        subtotal[16] = precio[16] * cantidad[16];
                        total = total + subtotal[16];
                    }
                    #endregion TextBox16
                    #region TextBox17
                    if (textBox17.Text != "")
                    {
                        int temp = int.Parse(textBox17.Text);
                        cantidad[17] = temp;
                        subtotal[17] = precio[17] * cantidad[17];
                        total = total + subtotal[17];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[17] = temp;
                        subtotal[17] = precio[17] * cantidad[17];
                        total = total + subtotal[17];
                    }
                    #endregion TextBox17
                    #region TextBox18
                    if (textBox18.Text != "")
                    {
                        int temp = int.Parse(textBox18.Text);
                        cantidad[18] = temp;
                        subtotal[18] = precio[18] * cantidad[18];
                        total = total + subtotal[18];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[18] = temp;
                        subtotal[18] = precio[18] * cantidad[18];
                        total = total + subtotal[18];
                    }
                    #endregion TextBox18
                    #region TextBox19
                    if (textBox19.Text != "")
                    {
                        int temp = int.Parse(textBox19.Text);
                        cantidad[19] = temp;
                        subtotal[19] = precio[19] * cantidad[19];
                        total = total + subtotal[19];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[19] = temp;
                        subtotal[19] = precio[19] * cantidad[19];
                        total = total + subtotal[19];
                    }
                    #endregion TextBox19
                    #region TextBox20
                    if (textBox20.Text != "")
                    {
                        int temp = int.Parse(textBox20.Text);
                        cantidad[20] = temp;
                        subtotal[20] = precio[20] * cantidad[20];
                        total = total + subtotal[20];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[20] = temp;
                        subtotal[20] = precio[20] * cantidad[20];
                        total = total + subtotal[20];
                    }
                    #endregion TextBox20


                }
                if (checkBox102.Checked == true)
                {
                    PreciosOP2();
                    #region TextBox21
                    if (textBox21.Text != "")
                    {
                        int temp = int.Parse(textBox21.Text);
                        cantidad[21] = temp;
                        subtotal[21] = precio[21] * cantidad[21];
                        total = total + subtotal[21];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[21] = temp;
                        subtotal[21] = precio[21] * cantidad[21];
                        total = total + subtotal[21];
                    }
                    #endregion TextBox21
                    #region TextBox22
                    if (textBox22.Text != "")
                    {
                        int temp = int.Parse(textBox22.Text);
                        cantidad[22] = temp;
                        subtotal[22] = precio[22] * cantidad[22];
                        total = total + subtotal[22];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[22] = temp;
                        subtotal[22] = precio[22] * cantidad[22];
                        total = total + subtotal[22];
                    }
                    #endregion TextBox2
                    #region TextBox23
                    if (textBox23.Text != "")
                    {
                        int temp = int.Parse(textBox23.Text);
                        cantidad[23] = temp;
                        subtotal[23] = precio[23] * cantidad[23];
                        total = total + subtotal[23];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[23] = temp;
                        subtotal[23] = precio[23] * cantidad[23];
                        total = total + subtotal[23];
                    }
                    #endregion TextBox3
                    #region TextBox24
                    if (textBox24.Text != "")
                    {
                        int temp = int.Parse(textBox24.Text);
                        cantidad[24] = temp;
                        subtotal[24] = precio[24] * cantidad[24];
                        total = total + subtotal[24];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[24] = temp;
                        subtotal[24] = precio[24] * cantidad[24];
                        total = total + subtotal[24];
                    }
                    #endregion TextBox4
                    #region TextBox25
                    if (textBox25.Text != "")
                    {
                        int temp = int.Parse(textBox25.Text);
                        cantidad[25] = temp;
                        subtotal[25] = precio[25] * cantidad[25];
                        total = total + subtotal[25];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[25] = temp;
                        subtotal[25] = precio[25] * cantidad[25];
                        total = total + subtotal[25];
                    }
                    #endregion TextBox5
                    #region TextBox26
                    if (textBox26.Text != "")
                    {
                        int temp = int.Parse(textBox26.Text);
                        cantidad[26] = temp;
                        subtotal[26] = precio[26] * cantidad[26];
                        total = total + subtotal[26];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[26] = temp;
                        subtotal[26] = precio[26] * cantidad[26];
                        total = total + subtotal[26];
                    }
                    #endregion TextBox6
                    #region TextBox27
                    if (textBox27.Text != "")
                    {
                        int temp = int.Parse(textBox27.Text);
                        cantidad[27] = temp;
                        subtotal[27] = precio[27] * cantidad[27];
                        total = total + subtotal[27];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[27] = temp;
                        subtotal[27] = precio[27] * cantidad[27];
                        total = total + subtotal[27];
                    }
                    #endregion TextBox7
                    #region TextBox28
                    if (textBox28.Text != "")
                    {
                        int temp = int.Parse(textBox28.Text);
                        cantidad[28] = temp;
                        subtotal[28] = precio[28] * cantidad[28];
                        total = total + subtotal[28];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[28] = temp;
                        subtotal[28] = precio[28] * cantidad[28];
                        total = total + subtotal[28];
                    }
                    #endregion TextBox8
                    #region TextBox29
                    if (textBox29.Text != "")
                    {
                        int temp = int.Parse(textBox29.Text);
                        cantidad[29] = temp;
                        subtotal[29] = precio[29] * cantidad[29];
                        total = total + subtotal[29];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[29] = temp;
                        subtotal[29] = precio[29] * cantidad[29];
                        total = total + subtotal[29];
                    }
                    #endregion TextBox9
                    #region TextBox30
                    if (textBox30.Text != "")
                    {
                        int temp = int.Parse(textBox30.Text);
                        cantidad[30] = temp;
                        subtotal[30] = precio[30] * cantidad[30];
                        total = total + subtotal[30];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[30] = temp;
                        subtotal[30] = precio[30] * cantidad[30];
                        total = total + subtotal[30];
                    }
                    #endregion TextBox10
                    #region TextBox31
                    if (textBox31.Text != "")
                    {
                        int temp = int.Parse(textBox31.Text);
                        cantidad[31] = temp;
                        subtotal[31] = precio[31] * cantidad[31];
                        total = total + subtotal[31];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[31] = temp;
                        subtotal[31] = precio[31] * cantidad[31];
                        total = total + subtotal[31];
                    }
                    #endregion TextBox11
                    #region TextBox32
                    if (textBox32.Text != "")
                    {
                        int temp = int.Parse(textBox32.Text);
                        cantidad[32] = temp;
                        subtotal[32] = precio[32] * cantidad[32];
                        total = total + subtotal[32];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[32] = temp;
                        subtotal[32] = precio[32] * cantidad[32];
                        total = total + subtotal[32];
                    }
                    #endregion TextBox32
                    #region TextBox33
                    if (textBox33.Text != "")
                    {
                        int temp = int.Parse(textBox33.Text);
                        cantidad[33] = temp;
                        subtotal[33] = precio[33] * cantidad[33];
                        total = total + subtotal[33];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[33] = temp;
                        subtotal[33] = precio[33] * cantidad[33];
                        total = total + subtotal[33];
                    }
                    #endregion TextBox13
                    #region TextBox34
                    if (textBox34.Text != "")
                    {
                        int temp = int.Parse(textBox34.Text);
                        cantidad[34] = temp;
                        subtotal[34] = precio[34] * cantidad[34];
                        total = total + subtotal[34];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[34] = temp;
                        subtotal[34] = precio[34] * cantidad[34];
                        total = total + subtotal[34];
                    }
                    #endregion TextBox14
                    #region TextBox35
                    if (textBox35.Text != "")
                    {
                        int temp = int.Parse(textBox35.Text);
                        cantidad[35] = temp;
                        subtotal[35] = precio[35] * cantidad[35];
                        total = total + subtotal[35];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[35] = temp;
                        subtotal[35] = precio[35] * cantidad[35];
                        total = total + subtotal[35];
                    }
                    #endregion TextBox15
                    #region TextBox36
                    if (textBox36.Text != "")
                    {
                        int temp = int.Parse(textBox36.Text);
                        cantidad[36] = temp;
                        subtotal[36] = precio[36] * cantidad[36];
                        total = total + subtotal[36];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[36] = temp;
                        subtotal[36] = precio[36] * cantidad[36];
                        total = total + subtotal[36];
                    }
                    #endregion TextBox16
                    #region TextBox37
                    if (textBox37.Text != "")
                    {
                        int temp = int.Parse(textBox37.Text);
                        cantidad[37] = temp;
                        subtotal[37] = precio[37] * cantidad[37];
                        total = total + subtotal[37];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[37] = temp;
                        subtotal[37] = precio[37] * cantidad[37];
                        total = total + subtotal[37];
                    }
                    #endregion TextBox17
                    #region TextBox38
                    if (textBox38.Text != "")
                    {
                        int temp = int.Parse(textBox38.Text);
                        cantidad[38] = temp;
                        subtotal[38] = precio[38] * cantidad[38];
                        total = total + subtotal[38];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[38] = temp;
                        subtotal[38] = precio[38] * cantidad[38];
                        total = total + subtotal[38];
                    }
                    #endregion TextBox18
                    #region TextBox39
                    if (textBox39.Text != "")
                    {
                        int temp = int.Parse(textBox39.Text);
                        cantidad[39] = temp;
                        subtotal[39] = precio[39] * cantidad[39];
                        total = total + subtotal[39];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[39] = temp;
                        subtotal[39] = precio[39] * cantidad[39];
                        total = total + subtotal[39];
                    }
                    #endregion TextBox19
                    #region TextBox40
                    if (textBox40.Text != "")
                    {
                        int temp = int.Parse(textBox40.Text);
                        cantidad[40] = temp;
                        subtotal[40] = precio[40] * cantidad[40];
                        total = total + subtotal[40];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[40] = temp;
                        subtotal[40] = precio[40] * cantidad[40];
                        total = total + subtotal[40];
                    }
                    #endregion TextBox20
                }
                if (checkBox103.Checked == true)
                {
                    PreciosOP3();
                    #region TextBox41
                    if (textBox41.Text != "")
                    {
                        int temp = int.Parse(textBox41.Text);
                        cantidad[41] = temp;
                        subtotal[41] = precio[41] * cantidad[41];
                        total = total + subtotal[41];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[41] = temp;
                        subtotal[41] = precio[41] * cantidad[41];
                        total = total + subtotal[41];
                    }
                    #endregion TextBox21
                    #region TextBox42
                    if (textBox42.Text != "")
                    {
                        int temp = int.Parse(textBox42.Text);
                        cantidad[42] = temp;
                        subtotal[42] = precio[42] * cantidad[42];
                        total = total + subtotal[42];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[42] = temp;
                        subtotal[42] = precio[42] * cantidad[42];
                        total = total + subtotal[42];
                    }
                    #endregion TextBox2
                    #region TextBox43
                    if (textBox43.Text != "")
                    {
                        int temp = int.Parse(textBox43.Text);
                        cantidad[43] = temp;
                        subtotal[43] = precio[43] * cantidad[43];
                        total = total + subtotal[43];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[43] = temp;
                        subtotal[43] = precio[43] * cantidad[43];
                        total = total + subtotal[43];
                    }
                    #endregion TextBox3
                    #region TextBox44
                    if (textBox44.Text != "")
                    {
                        int temp = int.Parse(textBox44.Text);
                        cantidad[44] = temp;
                        subtotal[44] = precio[44] * cantidad[44];
                        total = total + subtotal[44];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[44] = temp;
                        subtotal[44] = precio[44] * cantidad[44];
                        total = total + subtotal[44];
                    }
                    #endregion TextBox4
                    #region TextBox45
                    if (textBox45.Text != "")
                    {
                        int temp = int.Parse(textBox45.Text);
                        cantidad[45] = temp;
                        subtotal[45] = precio[45] * cantidad[45];
                        total = total + subtotal[45];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[45] = temp;
                        subtotal[45] = precio[45] * cantidad[45];
                        total = total + subtotal[45];
                    }
                    #endregion TextBox5
                    #region TextBox46
                    if (textBox46.Text != "")
                    {
                        int temp = int.Parse(textBox46.Text);
                        cantidad[46] = temp;
                        subtotal[46] = precio[46] * cantidad[46];
                        total = total + subtotal[46];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[46] = temp;
                        subtotal[46] = precio[46] * cantidad[46];
                        total = total + subtotal[46];
                    }
                    #endregion TextBox6
                    #region TextBox47
                    if (textBox47.Text != "")
                    {
                        int temp = int.Parse(textBox47.Text);
                        cantidad[47] = temp;
                        subtotal[47] = precio[47] * cantidad[47];
                        total = total + subtotal[47];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[47] = temp;
                        subtotal[47] = precio[47] * cantidad[47];
                        total = total + subtotal[47];
                    }
                    #endregion TextBox7
                    #region TextBox48
                    if (textBox48.Text != "")
                    {
                        int temp = int.Parse(textBox48.Text);
                        cantidad[48] = temp;
                        subtotal[48] = precio[48] * cantidad[48];
                        total = total + subtotal[48];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[48] = temp;
                        subtotal[48] = precio[48] * cantidad[48];
                        total = total + subtotal[48];
                    }
                    #endregion TextBox8
                    #region TextBox49
                    if (textBox49.Text != "")
                    {
                        int temp = int.Parse(textBox49.Text);
                        cantidad[49] = temp;
                        subtotal[49] = precio[49] * cantidad[49];
                        total = total + subtotal[49];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[49] = temp;
                        subtotal[49] = precio[49] * cantidad[49];
                        total = total + subtotal[49];
                    }
                    #endregion TextBox9
                    #region TextBox50
                    if (textBox50.Text != "")
                    {
                        int temp = int.Parse(textBox50.Text);
                        cantidad[50] = temp;
                        subtotal[50] = precio[50] * cantidad[50];
                        total = total + subtotal[50];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[50] = temp;
                        subtotal[50] = precio[50] * cantidad[50];
                        total = total + subtotal[50];
                    }
                    #endregion TextBox10
                    #region TextBox51
                    if (textBox51.Text != "")
                    {
                        int temp = int.Parse(textBox51.Text);
                        cantidad[51] = temp;
                        subtotal[51] = precio[51] * cantidad[51];
                        total = total + subtotal[51];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[51] = temp;
                        subtotal[51] = precio[51] * cantidad[51];
                        total = total + subtotal[51];
                    }
                    #endregion TextBox11
                    #region TextBox52
                    if (textBox52.Text != "")
                    {
                        int temp = int.Parse(textBox52.Text);
                        cantidad[52] = temp;
                        subtotal[52] = precio[52] * cantidad[52];
                        total = total + subtotal[52];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[52] = temp;
                        subtotal[52] = precio[52] * cantidad[52];
                        total = total + subtotal[52];
                    }
                    #endregion TextBox32
                    #region TextBox53
                    if (textBox53.Text != "")
                    {
                        int temp = int.Parse(textBox53.Text);
                        cantidad[53] = temp;
                        subtotal[53] = precio[53] * cantidad[53];
                        total = total + subtotal[53];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[53] = temp;
                        subtotal[53] = precio[53] * cantidad[53];
                        total = total + subtotal[53];
                    }
                    #endregion TextBox13
                    #region TextBox54
                    if (textBox54.Text != "")
                    {
                        int temp = int.Parse(textBox54.Text);
                        cantidad[54] = temp;
                        subtotal[54] = precio[54] * cantidad[54];
                        total = total + subtotal[54];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[54] = temp;
                        subtotal[54] = precio[54] * cantidad[54];
                        total = total + subtotal[54];
                    }
                    #endregion TextBox14
                    #region TextBox55
                    if (textBox55.Text != "")
                    {
                        int temp = int.Parse(textBox55.Text);
                        cantidad[55] = temp;
                        subtotal[55] = precio[55] * cantidad[55];
                        total = total + subtotal[55];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[55] = temp;
                        subtotal[55] = precio[55] * cantidad[55];
                        total = total + subtotal[55];
                    }
                    #endregion TextBox15
                    #region TextBox56
                    if (textBox56.Text != "")
                    {
                        int temp = int.Parse(textBox56.Text);
                        cantidad[56] = temp;
                        subtotal[56] = precio[56] * cantidad[56];
                        total = total + subtotal[56];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[56] = temp;
                        subtotal[56] = precio[56] * cantidad[56];
                        total = total + subtotal[56];
                    }
                    #endregion TextBox16
                    #region TextBox57
                    if (textBox57.Text != "")
                    {
                        int temp = int.Parse(textBox57.Text);
                        cantidad[57] = temp;
                        subtotal[57] = precio[57] * cantidad[57];
                        total = total + subtotal[57];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[57] = temp;
                        subtotal[57] = precio[57] * cantidad[57];
                        total = total + subtotal[57];
                    }
                    #endregion TextBox57
                    #region TextBox58
                    if (textBox58.Text != "")
                    {
                        int temp = int.Parse(textBox58.Text);
                        cantidad[58] = temp;
                        subtotal[58] = precio[58] * cantidad[58];
                        total = total + subtotal[58];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[58] = temp;
                        subtotal[58] = precio[58] * cantidad[58];
                        total = total + subtotal[58];
                    }
                    #endregion TextBox18
                    #region TextBox59
                    if (textBox59.Text != "")
                    {
                        int temp = int.Parse(textBox59.Text);
                        cantidad[59] = temp;
                        subtotal[59] = precio[59] * cantidad[59];
                        total = total + subtotal[59];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[59] = temp;
                        subtotal[59] = precio[59] * cantidad[59];
                        total = total + subtotal[59];
                    }
                    #endregion TextBox19
                    #region TextBox60
                    if (textBox60.Text != "")
                    {
                        int temp = int.Parse(textBox60.Text);
                        cantidad[60] = temp;
                        subtotal[60] = precio[60] * cantidad[60];
                        total = total + subtotal[60];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[60] = temp;
                        subtotal[60] = precio[60] * cantidad[60];
                        total = total + subtotal[60];
                    }
                    #endregion TextBox20
                }
                 if (checkBox104.Checked == true)
                {
                    PreciosOP4();
                    #region TextBox61
                    if (textBox61.Text != "")
                    {
                        int temp = int.Parse(textBox61.Text);
                        cantidad[61] = temp;
                        subtotal[61] = precio[61] * cantidad[61];
                        total = total + subtotal[61];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[61] = temp;
                        subtotal[61] = precio[61] * cantidad[61];
                        total = total + subtotal[61];
                    }
                    #endregion TextBox21
                    #region TextBox62
                    if (textBox62.Text != "")
                    {
                        int temp = int.Parse(textBox62.Text);
                        cantidad[62] = temp;
                        subtotal[62] = precio[62] * cantidad[62];
                        total = total + subtotal[62];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[62] = temp;
                        subtotal[62] = precio[62] * cantidad[62];
                        total = total + subtotal[62];
                    }
                    #endregion TextBox2
                    #region TextBox63
                    if (textBox63.Text != "")
                    {
                        int temp = int.Parse(textBox63.Text);
                        cantidad[63] = temp;
                        subtotal[63] = precio[63] * cantidad[63];
                        total = total + subtotal[63];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[63] = temp;
                        subtotal[63] = precio[63] * cantidad[63];
                        total = total + subtotal[63];
                    }
                    #endregion TextBox3
                    #region TextBox64
                    if (textBox64.Text != "")
                    {
                        int temp = int.Parse(textBox64.Text);
                        cantidad[64] = temp;
                        subtotal[64] = precio[64] * cantidad[64];
                        total = total + subtotal[64];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[64] = temp;
                        subtotal[64] = precio[64] * cantidad[64];
                        total = total + subtotal[64];
                    }
                    #endregion TextBox4
                    #region TextBox65
                    if (textBox65.Text != "")
                    {
                        int temp = int.Parse(textBox65.Text);
                        cantidad[65] = temp;
                        subtotal[65] = precio[65] * cantidad[65];
                        total = total + subtotal[65];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[65] = temp;
                        subtotal[65] = precio[65] * cantidad[65];
                        total = total + subtotal[65];
                    }
                    #endregion TextBox5
                    #region TextBox66
                    if (textBox66.Text != "")
                    {
                        int temp = int.Parse(textBox66.Text);
                        cantidad[66] = temp;
                        subtotal[66] = precio[66] * cantidad[66];
                        total = total + subtotal[66];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[66] = temp;
                        subtotal[66] = precio[66] * cantidad[66];
                        total = total + subtotal[66];
                    }
                    #endregion TextBox6
                    #region TextBox67
                    if (textBox67.Text != "")
                    {
                        int temp = int.Parse(textBox67.Text);
                        cantidad[67] = temp;
                        subtotal[67] = precio[67] * cantidad[67];
                        total = total + subtotal[67];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[67] = temp;
                        subtotal[67] = precio[67] * cantidad[67];
                        total = total + subtotal[67];
                    }
                    #endregion TextBox7
                    #region TextBox68
                    if (textBox68.Text != "")
                    {
                        int temp = int.Parse(textBox68.Text);
                        cantidad[68] = temp;
                        subtotal[68] = precio[68] * cantidad[68];
                        total = total + subtotal[68];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[68] = temp;
                        subtotal[68] = precio[68] * cantidad[68];
                        total = total + subtotal[68];
                    }
                    #endregion TextBox8
                    #region TextBox69
                    if (textBox69.Text != "")
                    {
                        int temp = int.Parse(textBox69.Text);
                        cantidad[69] = temp;
                        subtotal[69] = precio[69] * cantidad[69];
                        total = total + subtotal[69];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[69] = temp;
                        subtotal[69] = precio[69] * cantidad[69];
                        total = total + subtotal[69];
                    }
                    #endregion TextBox9
                    #region TextBox70
                    if (textBox70.Text != "")
                    {
                        int temp = int.Parse(textBox70.Text);
                        cantidad[70] = temp;
                        subtotal[70] = precio[70] * cantidad[70];
                        total = total + subtotal[70];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[70] = temp;
                        subtotal[70] = precio[70] * cantidad[70];
                        total = total + subtotal[70];
                    }
                    #endregion TextBox10
                    #region TextBox71
                    if (textBox71.Text != "")
                    {
                        int temp = int.Parse(textBox71.Text);
                        cantidad[71] = temp;
                        subtotal[71] = precio[71] * cantidad[71];
                        total = total + subtotal[71];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[71] = temp;
                        subtotal[71] = precio[71] * cantidad[71];
                        total = total + subtotal[71];
                    }
                    #endregion TextBox11
                    #region TextBox72
                    if (textBox72.Text != "")
                    {
                        int temp = int.Parse(textBox72.Text);
                        cantidad[72] = temp;
                        subtotal[72] = precio[72] * cantidad[72];
                        total = total + subtotal[72];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[72] = temp;
                        subtotal[72] = precio[72] * cantidad[72];
                        total = total + subtotal[72];
                    }
                    #endregion TextBox32
                    #region TextBox73
                    if (textBox73.Text != "")
                    {
                        int temp = int.Parse(textBox73.Text);
                        cantidad[73] = temp;
                        subtotal[73] = precio[73] * cantidad[73];
                        total = total + subtotal[73];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[73] = temp;
                        subtotal[73] = precio[73] * cantidad[73];
                        total = total + subtotal[73];
                    }
                    #endregion TextBox13
                    #region TextBox74
                    if (textBox74.Text != "")
                    {
                        int temp = int.Parse(textBox74.Text);
                        cantidad[74] = temp;
                        subtotal[74] = precio[74] * cantidad[74];
                        total = total + subtotal[74];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[74] = temp;
                        subtotal[74] = precio[74] * cantidad[74];
                        total = total + subtotal[74];
                    }
                    #endregion TextBox14
                    #region TextBox75
                    if (textBox75.Text != "")
                    {
                        int temp = int.Parse(textBox75.Text);
                        cantidad[75] = temp;
                        subtotal[75] = precio[75] * cantidad[75];
                        total = total + subtotal[75];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[75] = temp;
                        subtotal[75] = precio[75] * cantidad[75];
                        total = total + subtotal[75];
                    }
                    #endregion TextBox15
                    #region TextBox76
                    if (textBox76.Text != "")
                    {
                        int temp = int.Parse(textBox76.Text);
                        cantidad[76] = temp;
                        subtotal[76] = precio[76] * cantidad[76];
                        total = total + subtotal[76];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[76] = temp;
                        subtotal[76] = precio[76] * cantidad[76];
                        total = total + subtotal[76];
                    }
                    #endregion TextBox16
                    #region TextBox77
                    if (textBox77.Text != "")
                    {
                        int temp = int.Parse(textBox77.Text);
                        cantidad[77] = temp;
                        subtotal[77] = precio[77] * cantidad[77];
                        total = total + subtotal[77];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[77] = temp;
                        subtotal[77] = precio[77] * cantidad[77];
                        total = total + subtotal[77];
                    }
                    #endregion TextBox7
                    #region TextBox78
                    if (textBox78.Text != "")
                    {
                        int temp = int.Parse(textBox78.Text);
                        cantidad[78] = temp;
                        subtotal[78] = precio[78] * cantidad[78];
                        total = total + subtotal[78];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[78] = temp;
                        subtotal[78] = precio[78] * cantidad[78];
                        total = total + subtotal[78];
                    }
                    #endregion TextBox18
                    #region TextBox79
                    if (textBox79.Text != "")
                    {
                        int temp = int.Parse(textBox79.Text);
                        cantidad[79] = temp;
                        subtotal[79] = precio[79] * cantidad[79];
                        total = total + subtotal[79];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[79] = temp;
                        subtotal[79] = precio[79] * cantidad[79];
                        total = total + subtotal[79];
                    }
                    #endregion TextBox19
                    #region TextBox80
                    if (textBox80.Text != "")
                    {
                        int temp = int.Parse(textBox80.Text);
                        cantidad[80] = temp;
                        subtotal[80] = precio[80] * cantidad[80];
                        total = total + subtotal[80];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[80] = temp;
                        subtotal[80] = precio[80] * cantidad[80];
                        total = total + subtotal[80];
                    }
                    #endregion TextBox20
                }
                if (checkBox105.Checked == true)
                {
                    PreciosOP5();
                    #region TextBox81
                    if (textBox81.Text != "")
                    {
                        int temp = int.Parse(textBox81.Text);
                        cantidad[81] = temp;
                        subtotal[81] = precio[81] * cantidad[81];
                        total = total + subtotal[81];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[81] = temp;
                        subtotal[81] = precio[81] * cantidad[81];
                        total = total + subtotal[81];
                    }
                    #endregion TextBox21
                    #region TextBox82
                    if (textBox82.Text != "")
                    {
                        int temp = int.Parse(textBox82.Text);
                        cantidad[82] = temp;
                        subtotal[82] = precio[82] * cantidad[82];
                        total = total + subtotal[82];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[82] = temp;
                        subtotal[82] = precio[82] * cantidad[82];
                        total = total + subtotal[82];
                    }
                    #endregion TextBox2
                    #region TextBox83
                    if (textBox83.Text != "")
                    {
                        int temp = int.Parse(textBox83.Text);
                        cantidad[83] = temp;
                        subtotal[83] = precio[83] * cantidad[83];
                        total = total + subtotal[83];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[83] = temp;
                        subtotal[83] = precio[83] * cantidad[83];
                        total = total + subtotal[83];
                    }
                    #endregion TextBox3
                    #region TextBox84
                    if (textBox84.Text != "")
                    {
                        int temp = int.Parse(textBox84.Text);
                        cantidad[84] = temp;
                        subtotal[84] = precio[84] * cantidad[84];
                        total = total + subtotal[84];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[84] = temp;
                        subtotal[84] = precio[84] * cantidad[84];
                        total = total + subtotal[84];
                    }
                    #endregion TextBox4
                    #region TextBox85
                    if (textBox85.Text != "")
                    {
                        int temp = int.Parse(textBox85.Text);
                        cantidad[85] = temp;
                        subtotal[85] = precio[85] * cantidad[85];
                        total = total + subtotal[85];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[85] = temp;
                        subtotal[85] = precio[85] * cantidad[85];
                        total = total + subtotal[85];
                    }
                    #endregion TextBox5
                    #region TextBox86
                    if (textBox86.Text != "")
                    {
                        int temp = int.Parse(textBox86.Text);
                        cantidad[86] = temp;
                        subtotal[86] = precio[86] * cantidad[86];
                        total = total + subtotal[86];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[86] = temp;
                        subtotal[86] = precio[86] * cantidad[86];
                        total = total + subtotal[86];
                    }
                    #endregion TextBox6
                    #region TextBox87
                    if (textBox87.Text != "")
                    {
                        int temp = int.Parse(textBox87.Text);
                        cantidad[87] = temp;
                        subtotal[87] = precio[87] * cantidad[87];
                        total = total + subtotal[87];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[87] = temp;
                        subtotal[87] = precio[87] * cantidad[87];
                        total = total + subtotal[87];
                    }
                    #endregion TextBox7
                    #region TextBox88
                    if (textBox88.Text != "")
                    {
                        int temp = int.Parse(textBox88.Text);
                        cantidad[88] = temp;
                        subtotal[88] = precio[88] * cantidad[88];
                        total = total + subtotal[88];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[88] = temp;
                        subtotal[88] = precio[88] * cantidad[88];
                        total = total + subtotal[88];
                    }
                    #endregion TextBox8
                    #region TextBox89
                    if (textBox89.Text != "")
                    {
                        int temp = int.Parse(textBox89.Text);
                        cantidad[89] = temp;
                        subtotal[89] = precio[89] * cantidad[89];
                        total = total + subtotal[89];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[89] = temp;
                        subtotal[89] = precio[89] * cantidad[89];
                        total = total + subtotal[89];
                    }
                    #endregion TextBox9
                    #region TextBox90
                    if (textBox90.Text != "")
                    {
                        int temp = int.Parse(textBox90.Text);
                        cantidad[90] = temp;
                        subtotal[90] = precio[90] * cantidad[90];
                        total = total + subtotal[90];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[90] = temp;
                        subtotal[90] = precio[90] * cantidad[90];
                        total = total + subtotal[90];
                    }
                    #endregion TextBox10
                    #region TextBox91
                    if (textBox91.Text != "")
                    {
                        int temp = int.Parse(textBox91.Text);
                        cantidad[91] = temp;
                        subtotal[91] = precio[91] * cantidad[91];
                        total = total + subtotal[91];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[91] = temp;
                        subtotal[91] = precio[91] * cantidad[91];
                        total = total + subtotal[91];
                    }
                    #endregion TextBox11
                    #region TextBox92
                    if (textBox92.Text != "")
                    {
                        int temp = int.Parse(textBox92.Text);
                        cantidad[92] = temp;
                        subtotal[92] = precio[92] * cantidad[92];
                        total = total + subtotal[92];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[92] = temp;
                        subtotal[92] = precio[92] * cantidad[92];
                        total = total + subtotal[92];
                    }
                    #endregion TextBox32
                    #region TextBox93
                    if (textBox93.Text != "")
                    {
                        int temp = int.Parse(textBox93.Text);
                        cantidad[93] = temp;
                        subtotal[93] = precio[93] * cantidad[93];
                        total = total + subtotal[93];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[93] = temp;
                        subtotal[93] = precio[93] * cantidad[93];
                        total = total + subtotal[93];
                    }
                    #endregion TextBox13
                    #region TextBox94
                    if (textBox94.Text != "")
                    {
                        int temp = int.Parse(textBox94.Text);
                        cantidad[94] = temp;
                        subtotal[94] = precio[94] * cantidad[94];
                        total = total + subtotal[94];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[94] = temp;
                        subtotal[94] = precio[94] * cantidad[94];
                        total = total + subtotal[94];
                    }
                    #endregion TextBox14
                    #region TextBox95
                    if (textBox95.Text != "")
                    {
                        int temp = int.Parse(textBox95.Text);
                        cantidad[95] = temp;
                        subtotal[95] = precio[95] * cantidad[95];
                        total = total + subtotal[95];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[95] = temp;
                        subtotal[95] = precio[95] * cantidad[95];
                        total = total + subtotal[95];
                    }
                    #endregion TextBox15
                    #region TextBox96
                    if (textBox96.Text != "")
                    {
                        int temp = int.Parse(textBox96.Text);
                        cantidad[96] = temp;
                        subtotal[96] = precio[96] * cantidad[96];
                        total = total + subtotal[96];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[96] = temp;
                        subtotal[96] = precio[96] * cantidad[96];
                        total = total + subtotal[96];
                    }
                    #endregion TextBox16
                    #region TextBox97
                    if (textBox97.Text != "")
                    {
                        int temp = int.Parse(textBox97.Text);
                        cantidad[97] = temp;
                        subtotal[97] = precio[97] * cantidad[97];
                        total = total + subtotal[97];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[97] = temp;
                        subtotal[97] = precio[97] * cantidad[97];
                        total = total + subtotal[97];
                    }
                    #endregion TextBox7
                    #region TextBox98
                    if (textBox98.Text != "")
                    {
                        int temp = int.Parse(textBox98.Text);
                        cantidad[98] = temp;
                        subtotal[98] = precio[98] * cantidad[98];
                        total = total + subtotal[98];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[98] = temp;
                        subtotal[98] = precio[98] * cantidad[98];
                        total = total + subtotal[98];
                    }
                    #endregion TextBox18
                    #region TextBox99
                    if (textBox99.Text != "")
                    {
                        int temp = int.Parse(textBox99.Text);
                        cantidad[99] = temp;
                        subtotal[99] = precio[99] * cantidad[99];
                        total = total + subtotal[99];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[99] = temp;
                        subtotal[99] = precio[99] * cantidad[99];
                        total = total + subtotal[99];
                    }
                    #endregion TextBox19
                    #region TextBox100
                    if (textBox100.Text != "")
                    {
                        int temp = int.Parse(textBox100.Text);
                        cantidad[100] = temp;
                        subtotal[100] = precio[100] * cantidad[100];
                        total = total + subtotal[100];
                    }
                    else
                    {
                        int temp = 0;
                        cantidad[100] = temp;
                        subtotal[100] = precio[100] * cantidad[100];
                        total = total + subtotal[100];
                    }
                    #endregion TextBox20
                }


                listBox1.Items.Add("Cant.   Descripcion          Precio U     Sub Total");
                listBox1.Items.Add("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
                for (int cont = 1; cont <= 101; cont++)
                {
                    if (cantidad[cont] > 0)
                    {
                        listBox1.Items.Add(cantidad[cont] +"\t"+ op[cont] +"\t"+ precio[cont]+"\t"+ subtotal[cont]);
                    }
                }
                listBox1.Items.Add("________________________________________________________");
                listBox1.Items.Add("El total a pagar es: " + "\t"+"\t"+"\t" + total);
            }
            catch
            {

            }

            groupBox9.Visible = true;
            button1.Visible = false;
            button4.Visible = false;
            button5.Visible = true;

        }

        #region Error
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

   
            
        }
        #endregion Error

        private void button5_Click(object sender, EventArgs e)
        {
            
        }


    }
}
