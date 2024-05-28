using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_FinalProj
{
    public partial class charSelectForm : Form
    {
        private readonly LocItems items;
        public charSelectForm()
        {
            InitializeComponent();
            items = Program.items;
        }

        private void charSelectForm_Load(object sender, EventArgs e)
        {

        }
        int strength = 0, luck = 0, evasion = 0, dexterity = 0, vitality = 0;
        int remaining = 150;
        private void button2_Click(object sender, EventArgs e)
        {
            if (strength >= 0 && strength != 0)
            {
                strength -= 3;
                remaining += 3;
                Stat1.Text = strength.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (luck >= 0 && luck != 0)
            {
                luck -= 3;
                remaining += 3;
                Stat2.Text = luck.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (evasion >= 0 && evasion != 0)
            {
                evasion -= 3;
                remaining += 3;
                Stat3.Text = evasion.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (vitality >= 0 && vitality != 0)
            {
                vitality -= 3;
                remaining += 3;
                Stat4.Text = vitality.ToString();
                Stats.Text = remaining.ToString();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dexterity >= 0 && dexterity != 0)
            {
                dexterity -= 3;
                remaining += 3;
                Stat5.Text = dexterity.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (strength != 51 && remaining != 0)
            {
                strength += 3;
                remaining -= 3;
                Stat1.Text = strength.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (luck != 27 && remaining != 0)
            {
                luck += 3;
                remaining -= 3;
                Stat2.Text = luck.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (evasion != 51 && remaining != 0)
            {
                evasion += 3;
                remaining -= 3;
                Stat3.Text = evasion.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (vitality != 51 && remaining != 0)
            {
                vitality += 3;
                remaining -= 3;
                Stat4.Text = vitality.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dexterity != 51 && remaining != 0)
            {
                dexterity += 3;
                remaining -= 3;
                Stat5.Text = dexterity.ToString();
                Stats.Text = remaining.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }
        int select;
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) { select = 1; }
            else if (radioButton2.Checked == true) { select = 3; }
            else if (radioButton3.Checked == true) { select = 2; }
            MessageBox.Show(
              Program.items.playerHealth.ToString() + "/" + Program.items.Maxhealth.ToString());
            if (remaining == 0 && select != 0)
            {
                if (select == 1)
                {
                    Program.items.playerstats[0] = strength + 50;
                    Program.items.playerstats[1] = 0;
                    Program.items.playerstats[2] = 0;
                    Program.items.playerstats[3] = 0;
                    Program.items.playerstats[4] = dexterity;
                    Program.items.playerstats[5] = luck;
                    Program.items.playerstats[6] = evasion;
                    Program.items.playerstats[7] = vitality + 50;
                    Program.items.playerHealth = (vitality + 50) * 15 + 300;
                    Program.items.Maxhealth = Program.items.playerHealth;
                    Program.items.classSelected = 1;
                }
                else if (select == 2)
                {
                    Program.items.playerstats[0] = strength + 20;
                    Program.items.playerstats[1] = 0;
                    Program.items.playerstats[2] = 0;
                    Program.items.playerstats[3] = 0;
                    Program.items.playerstats[4] = dexterity + 30;
                    Program.items.playerstats[5] = luck + 10;
                    Program.items.playerstats[6] = evasion + 10;
                    Program.items.playerstats[7] = vitality + 20;
                    Program.items.playerHealth = (vitality + 20) * 15 + 200;
                    Program.items.Maxhealth = Program.items.playerHealth;
                    Program.items.classSelected = 2;
                }
                else if (select == 2)
                {
                    Program.items.playerstats[0] = 10;
                    Program.items.playerstats[1] = strength + 70;
                    Program.items.playerstats[2] = 0;
                    Program.items.playerstats[3] = 0;
                    Program.items.playerstats[4] = dexterity;
                    Program.items.playerstats[5] = luck + 20;
                    Program.items.playerstats[6] = evasion + 10;
                    Program.items.playerstats[7] = vitality + 10;
                    Program.items.playerHealth = (vitality + 10) * 15 + 200;
                    Program.items.Maxhealth = Program.items.playerHealth;
                    Program.items.classSelected = 3;
                }

                JuraForestForm1 JFF = new JuraForestForm1();
                this.Hide();
                JFF.ShowDialog();
                this.Close();
            }
        }
    }
}
