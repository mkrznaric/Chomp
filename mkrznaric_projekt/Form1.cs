using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mkrznaric_projekt
{
    public partial class Form1 : Form
    {
        public int igrac = 1;

        public Form1()
        {
            InitializeComponent();
            Osvjezi();
        }

        public void Osvjezi()
        {
            label3.Text = igrac.ToString();
        }

        private void Akcija(Panel panel)
        {

            if(panel.BackColor == Color.Sienna)
            {
                panel.Visible = false;
            }
        }

        private void PromijeniIgraca()
        {
            if(igrac == 1)
            {
                igrac += 1;
                Osvjezi();
            }
            else
            {
                igrac -= 1;
                Osvjezi();
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Akcija(pnl1);
            PromijeniIgraca();
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (igrac == 2)
            {
                igrac -= 1;
                Osvjezi();
            }

            foreach (var panel in Controls.OfType<Panel>())
            {
                panel.BackColor = Color.Sienna;
                panel.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pnl2_Click(object sender, EventArgs e)
        {
            Akcija(pnl2);
            PromijeniIgraca();

            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void pnl3_Click(object sender, EventArgs e)
        {
            Akcija(pnl3);
            PromijeniIgraca();

            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void pnl4_Click(object sender, EventArgs e)
        {
            Akcija(pnl4);
            PromijeniIgraca();

            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void pnl5_Click(object sender, EventArgs e)
        {
            Akcija(pnl5);
            PromijeniIgraca();

            pnl6.Visible = false;
            pnl7.Visible = false;
        }

        private void pnl6_Click(object sender, EventArgs e)
        {
            Akcija(pnl6);
            PromijeniIgraca();

            pnl7.Visible = false;

        }

        private void pnl7_Click(object sender, EventArgs e)
        {
            Akcija(pnl7);
            PromijeniIgraca();
        }

        private void pnl8_Click(object sender, EventArgs e)
        {
            Akcija(pnl8);
            PromijeniIgraca();

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl9.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl9_Click(object sender, EventArgs e)
        {
            Akcija(pnl9);
            PromijeniIgraca();

            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;

        }

        private void pnl10_Click(object sender, EventArgs e)
        {
            Akcija(pnl10);
            PromijeniIgraca();

            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl11_Click(object sender, EventArgs e)
        {
            Akcija(pnl11);
            PromijeniIgraca();

            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl12_Click(object sender, EventArgs e)
        {
            Akcija(pnl12);
            PromijeniIgraca();

            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl13_Click(object sender, EventArgs e)
        {
            Akcija(pnl13);
            PromijeniIgraca();

            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl14_Click(object sender, EventArgs e)
        {
            Akcija(pnl14);
            PromijeniIgraca();

            pnl7.Visible = false;
        }

        private void pnl15_Click(object sender, EventArgs e)
        {
            Akcija(pnl15);
            PromijeniIgraca();
                    
            pnl1.Visible = false;  
            pnl2.Visible = false; 
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl8.Visible = false;
            pnl9.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl16.Visible = false;
            pnl17.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl16_Click(object sender, EventArgs e)
        {
            Akcija(pnl16);
            PromijeniIgraca();

            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl9.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl17.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl17_Click(object sender, EventArgs e)
        {
            Akcija(pnl17);
            PromijeniIgraca();

            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl18_Click(object sender, EventArgs e)
        {
            Akcija(pnl18);
            PromijeniIgraca();

            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl19_Click(object sender, EventArgs e)
        {
            Akcija(pnl19);
            PromijeniIgraca();

            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl20_Click(object sender, EventArgs e)
        {
            Akcija(pnl20);
            PromijeniIgraca();

            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl21.Visible = false;
        }

        private void pnl21_Click(object sender, EventArgs e)
        {
            Akcija(pnl21);
            PromijeniIgraca();

            pnl7.Visible = false;
            pnl14.Visible = false;
        }

        private void pnl22_Click(object sender, EventArgs e)
        {
            Akcija(pnl22);
            PromijeniIgraca();
            MessageBox.Show("Igrač "+igrac.ToString()+" je pobijedio!");
            foreach (var panel in Controls.OfType<Panel>())
            {
                panel.BackColor = Color.Sienna;
                panel.Visible = true;
            }

            if (igrac == 2)
            {
                igrac -= 1;
                Osvjezi();
            }
        }

        private void pnl23_Click(object sender, EventArgs e)
        {
            Akcija(pnl23);
            PromijeniIgraca();

            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl9.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl16.Visible = false;
            pnl17.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
            pnl24.Visible = false;
            pnl25.Visible = false;
            pnl26.Visible = false;
            pnl27.Visible = false;
            pnl28.Visible = false;
        }

        private void pnl24_Click(object sender, EventArgs e)
        {
            Akcija(pnl24);
            PromijeniIgraca();

            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl10.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl17.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
            pnl25.Visible = false;
            pnl26.Visible = false;
            pnl27.Visible = false;
            pnl28.Visible = false;
        }

        private void pnl25_Click(object sender, EventArgs e)
        {
            Akcija(pnl25);
            PromijeniIgraca();

            pnl4.Visible = false;
            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl11.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl18.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
            pnl26.Visible = false;
            pnl27.Visible = false;
            pnl28.Visible = false;
        }

        private void pnl26_Click(object sender, EventArgs e)
        {
            Akcija(pnl26);
            PromijeniIgraca();

            pnl5.Visible = false;
            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl12.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl19.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
            pnl27.Visible = false;
            pnl28.Visible = false;

        }

        private void pnl27_Click(object sender, EventArgs e)
        {
            Akcija(pnl27);
            PromijeniIgraca();

            pnl6.Visible = false;
            pnl7.Visible = false;
            pnl13.Visible = false;
            pnl14.Visible = false;
            pnl20.Visible = false;
            pnl21.Visible = false;
            pnl28.Visible = false;
        }

        private void pnl28_Click(object sender, EventArgs e)
        {
            Akcija(pnl28);
            PromijeniIgraca();

            pnl7.Visible = false;
            pnl14.Visible = false;
            pnl21.Visible = false;

        }
    }
}
