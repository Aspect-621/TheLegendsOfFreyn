using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_FinalProj
{
    public partial class CrestfallCityForm10 : Form
    {
        private readonly LocItems _items;

        int[,] obstacles = new int[48, 4];
        PictureBox[] obstacle = new PictureBox[48];
        PictureBox[] mob = new PictureBox[1];
        int[,] moblocation = new int[1, 4];
        string[] mobnames = new string[1];
        Label[] itemlb = new Label[9];
        PictureBox[] item = new PictureBox[9];
        private Image[] assets = new Image[21]; 
        
        private Image[] warrior = new Image[4];
        private Image[] archer = new Image[4];
        private Image[] mage = new Image[4];
        public CrestfallCityForm10()
        {
            InitializeComponent();
            _items = Program.items;
            item1.Tag = 0;
            item2.Tag = 1;
            item3.Tag = 2;
            item4.Tag = 3;
            item5.Tag = 4;
            item6.Tag = 5;
            item7.Tag = 6;
            item8.Tag = 7;
            item9.Tag = 8;

            // Assign the same event handler to each button
            item1.Click += new EventHandler(Item_Click);
            item2.Click += new EventHandler(Item_Click);
            item3.Click += new EventHandler(Item_Click);
            item4.Click += new EventHandler(Item_Click);
            item5.Click += new EventHandler(Item_Click);
            item6.Click += new EventHandler(Item_Click);
            item7.Click += new EventHandler(Item_Click);
            item8.Click += new EventHandler(Item_Click);
            item9.Click += new EventHandler(Item_Click);
        }
        private void TeleportChecker(int[] newPosition, int[,] moblocation, string[] mob)
        {
            for (int i = 0; i < moblocation.GetLength(0); i++)
            {
                if ((newPosition[1] <= moblocation[i, 3] + 5 && newPosition[1] >= moblocation[i, 1] - 5) &&
                    ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                    (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                    (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "TeleportTop")
                    {
                        Program.items.location[0] = 695;
                        Program.items.location[1] = 835;
                        CrestfallCityForm8 CCF = new CrestfallCityForm8();
                        this.Hide();
                        CCF.ShowDialog();
                        this.Close();
                    }
                    break;
                }

                else if (newPosition[0] <= moblocation[i, 2] + 5 && newPosition[0] >= moblocation[i, 0] - 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "TeleportLeft")
                    {
                        Program.items.location[0] = 1235;
                        Program.items.location[1] = 510;
                        CrestfallCityForm1 CCF = new CrestfallCityForm1();
                        this.Hide();
                        CCF.ShowDialog();
                        this.Close();
                    }
                    break;
                }

                else if (newPosition[3] >= moblocation[i, 1] - 5 && newPosition[3] <= moblocation[i, 3] + 5 &&
                   ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                   (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                   (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "TeleportBottom")
                    {
                        Program.items.location[0] = 695;
                        Program.items.location[1] = 120;
                        CrestfallCityForm8 CCF = new CrestfallCityForm8();
                        this.Hide();
                        CCF.ShowDialog();
                        this.Close();
                    }
                    break;
                }

                else if (newPosition[2] >= moblocation[i, 0] - 5 && newPosition[2] <= moblocation[i, 2] + 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "TeleportRight")
                    {
                        Program.items.location[0] = 145;
                        Program.items.location[1] = 510;
                        CrestfallCityForm6 CCF = new CrestfallCityForm6();
                        this.Hide();
                        CCF.ShowDialog();
                        this.Close();
                    }
                    break;
                }
            }
        }

        private void CrestfallCityForm10_Load(object sender, EventArgs e)
        {
            warrior[2] = Properties.Resources.sword_walk_front;
            warrior[1] = Properties.Resources.sword_walk_left;
            warrior[0] = Properties.Resources.sword_walk_back;
            warrior[3] = Properties.Resources.sword_walk_right;

            archer[2] = Properties.Resources.archer_walk_front;
            archer[1] = Properties.Resources.archer_walk_left;
            archer[0] = Properties.Resources.archer_walk_back;
            archer[3] = Properties.Resources.archer_walk_right;

            mage[2] = Properties.Resources.mage_walk_front;
            mage[1] = Properties.Resources.mage_walk_left;
            mage[0] = Properties.Resources.mage_walk_back;
            mage[3] = Properties.Resources.mage_walk_rigth;

            print();
            if (Program.items.classSelected == 1)
            {
                Player.Image = warrior[2];
            }
            else if (Program.items.classSelected == 2)
            {
                Player.Image = archer[2];
            }
            else if (Program.items.classSelected == 3)
            {
                Player.Image = mage[2];
            }
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.BackColor = Color.Transparent;
            assets[0] = null;
            assets[1] = Properties.Resources._0;
            assets[2] = Properties.Resources._1;
            assets[3] = Properties.Resources._2;
            assets[4] = Properties.Resources._3;
            assets[5] = Properties.Resources._4;
            assets[6] = Properties.Resources._5;
            assets[7] = Properties.Resources._6;
            assets[8] = Properties.Resources._7;
            assets[9] = Properties.Resources._8;
            assets[10] = Properties.Resources._9;
            assets[11] = Properties.Resources._10;
            assets[12] = Properties.Resources._11;
            assets[13] = Properties.Resources._12;
            assets[14] = Properties.Resources._13;
            assets[15] = Properties.Resources._14;
            assets[16] = Properties.Resources._15;
            assets[17] = Properties.Resources._16;
            assets[18] = Properties.Resources._17;
            assets[19] = Properties.Resources._18;
            assets[20] = Properties.Resources._19;

            item[0] = item1;
            item[1] = item2;
            item[2] = item3;
            item[3] = item4;
            item[4] = item5;
            item[5] = item6;
            item[6] = item7;
            item[7] = item8;
            item[8] = item9;

            itemlb[0] = itemlb1;
            itemlb[1] = itemlb2;
            itemlb[2] = itemlb3;
            itemlb[3] = itemlb4;
            itemlb[4] = itemlb5;
            itemlb[5] = itemlb6;
            itemlb[6] = itemlb7;
            itemlb[7] = itemlb8;
            itemlb[8] = itemlb9;
            Player.Location = new Point(Program.items.location[0], Program.items.location[1]);

            for (int i = 1; i <= 100; i++)
            {
                Control control = this.Controls["pictureBox" + i];
                if (control != null && control is PictureBox)
                {
                    ((PictureBox)control).BackColor = Color.Transparent;
                }
            }
            int counterObstacle = 0;
            //naming of variable para hindi mano mano
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name.StartsWith("pictureBox"))
                {
                    obstacle[counterObstacle] = (PictureBox)ctrl;
                    counterObstacle++;
                }
            }


            int counterMob = 0;


            foreach (Control ctrl in Controls)
            {
                if (ctrl.Name.StartsWith("mob"))
                {
                    mob[counterMob] = (PictureBox)ctrl;
                    counterMob++;
                }
            }

            for (int i = 0; i < obstacle.Length; i++)
            {
                obstacles[i, 0] = obstacle[i].Location.X;
                obstacles[i, 1] = obstacle[i].Location.Y;
                obstacles[i, 2] = obstacle[i].Location.X + obstacle[i].Size.Width;
                obstacles[i, 3] = obstacle[i].Location.Y + obstacle[i].Size.Height;
            }

            for (int x = 0; x < moblocation.GetLength(0); x++)
            {
                moblocation[x, 0] = mob[x].Location.X;
                moblocation[x, 1] = mob[x].Location.Y;
                moblocation[x, 2] = mob[x].Location.X + mob[x].Size.Width;
                moblocation[x, 3] = mob[x].Location.Y + mob[x].Size.Height;
                mobnames[x] = mob[x].AccessibleName;
            }

        }
        int lastkey;
        private void CrestfallCity_KeyDown_1(object sender, KeyEventArgs e)
        {
            int leftPosition, topPosition, rightPosition, bottomPosition;
            int[] movement = { 0, 0, 0, 0 };
            leftPosition = Player.Location.X;
            topPosition = Player.Location.Y;
            rightPosition = Player.Location.X + Player.Size.Width;
            bottomPosition = Player.Location.Y + Player.Size.Height;
            int keypressed = (int)e.KeyCode;
            if (keypressed == 87 && lastkey != 87)
            {
                if (Program.items.classSelected == 1)
                {
                    Player.Image = warrior[0];
                }
                else if (Program.items.classSelected == 2)
                {
                    Player.Image = archer[0];
                }
                else if (Program.items.classSelected == 3)
                {
                    Player.Image = mage[0];
                }

            }
            else if (keypressed == 65 && lastkey != 65)
            {
                if (Program.items.classSelected == 1)
                {
                    Player.Image = warrior[1];
                }
                else if (Program.items.classSelected == 2)
                {
                    Player.Image = archer[1];
                }
                else if (Program.items.classSelected == 3)
                {
                    Player.Image = mage[1];
                }
            }
            else if (keypressed == 83 && lastkey != 83)
            {
                if (Program.items.classSelected == 1)
                {
                    Player.Image = warrior[2];
                }
                else if (Program.items.classSelected == 2)
                {
                    Player.Image = archer[2];
                }
                else if (Program.items.classSelected == 3)
                {
                    Player.Image = mage[2];
                }
            }
            else if (keypressed == 68 && lastkey != 68)
            {
                if (Program.items.classSelected == 1)
                {
                    Player.Image = warrior[3];
                }
                else if (Program.items.classSelected == 2)
                {
                    Player.Image = archer[3];
                }
                else if (Program.items.classSelected == 3)
                {
                    Player.Image = mage[3];
                }
            }
            lastkey = keypressed;
            MovementPlayer newPosition = new MovementPlayer();
            movement = newPosition.Movement(leftPosition, topPosition, rightPosition, bottomPosition, keypressed, obstacles);
            Player.Location = new Point(movement[0], movement[1]);
            int[] newPos = { 0, 0, 0, 0 };
            newPos[0] = Player.Location.X;
            newPos[1] = Player.Location.Y;
            newPos[2] = Player.Location.X + Player.Size.Width;
            newPos[3] = Player.Location.Y + Player.Size.Height;
            newPosition.collisionChecker(newPos, moblocation, mobnames);
            TeleportChecker(newPos, moblocation, mobnames);
            InteractionChecker();
        }
        int entityType = 0;
        private void InteractionChecker()
        {
            if (entityType == 1)
            {
                MessageBox.Show("Combat");
            }
            else if (entityType == 2)
            {

            }
        }

        int[] itemindex;
        string[] itemname;
        int[] itemquan;
        int starting = 0;

        public void printitems(int starting)
        {
            itemindex = Program.items.availableItems();
            for (int x = 0; x < item.Length; x++)
            {
                itemlb[x].Text = "";
                item[x].Image = null;
            }
            for (int x = 0; x < itemlb.Length; x++)
            {
                if (itemlb[x].Text == "" && itemindex[x + starting] != 0)
                {
                    itemlb[x].Text = itemquan[itemindex[x + starting]].ToString();
                    item[x].Image = assets[itemindex[x + starting]];
                    item[x].SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
        }

        private void Less_Click(object sender, EventArgs e)
        {
            if (starting != 0)
            {
                starting -= 3;
                printitems(starting);
            }
        }

        private void More_Click(object sender, EventArgs e)
        {
            if (starting + 9 != 15)
            {
                starting += 3;
                printitems(starting);
            }
        }
        int select, current;
        private void Item_Click(object sender, EventArgs e)
        {
            PictureBox clickedButton = sender as PictureBox;
            if (clickedButton != null)
            {
                select = (int)clickedButton.Tag;
                current = itemindex[select + starting];
                Select.Image = assets[current];
                Select.SizeMode = PictureBoxSizeMode.StretchImage;
                select1.Text = itemquan[current].ToString();
            }
        }

        private void UseItem_Click(object sender, EventArgs e)
        {
            printitems(starting);
            if (current != 0)
            {
                Program.items.itemuse(current);
            }
        }

        private void OPEN_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            itemname = Program.items.name;
            itemquan = Program.items.quan;
            LocItems item = new LocItems();
            itemindex = item.availableItems();
            printitems(starting);

            if (starting == 0 && itemindex[9] == 0)
            {
                Less.Enabled = false;
                More.Enabled = false;
            }
            else
            {
                More.Enabled = true;
            }
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void print()
        {
            if (Program.items.classSelected == 1)
            {
                Idle.Image = warrior[3];
            }
            else if (Program.items.classSelected == 2)
            {
                Idle.Image = archer[3];
            }
            else if (Program.items.classSelected == 3)
            {
                Idle.Image = mage[3];
            }

            if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .9)
            {
                Health.Image = Properties.Resources._1_1;
            }
            else if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .8)
            {
                Health.Image = Properties.Resources._2_1;
            }
            else if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .6)
            {
                Health.Image = Properties.Resources._3_1;
            }
            else if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .4)
            {
                Health.Image = Properties.Resources._4_1;
            }
            else if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .2)
            {
                Health.Image = Properties.Resources._5_1;
            }
            else if (((float)Program.items.playerHealth / Program.items.Maxhealth) > .0)
            {
                Health.Image = Properties.Resources._6_1;
            }

            Stat1.Text = Program.items.playerstats[0].ToString();
            Stat2.Text = Program.items.playerstats[1].ToString();
            Stat3.Text = Program.items.playerstats[4].ToString();
            Stat4.Text = Program.items.playerstats[6].ToString();
            Stat5.Text = Program.items.playerstats[7].ToString();
            GoldPrint.Text = Program.items.gold.ToString();
        }
    }
}
