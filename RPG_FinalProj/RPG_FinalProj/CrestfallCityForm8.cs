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
using Trial1_Movement_Classes_COMPROGPROJ;

namespace RPG_FinalProj
{

    public partial class CrestfallCityForm8 : Form
    {
        private readonly LocItems _items;
        private readonly quest1Dialogue dialogues;
        int[,] obstacles = new int[29, 4];
        PictureBox[] obstacle = new PictureBox[29];
        PictureBox[] mob = new PictureBox[5];
        int[,] moblocation = new int[5, 4];
        string[] mobnames = new string[5];
        Label[] itemlb = new Label[9];
        private Image[] assets = new Image[21];
        PictureBox[] item = new PictureBox[9];

        PictureBox[] sell = new PictureBox[9];
        Label[] price = new Label[9];

        private Image[] warrior = new Image[4];
        private Image[] archer = new Image[4];
        private Image[] mage = new Image[4];
        public CrestfallCityForm8()
        {

            InitializeComponent();
            _items = Program.items;
            dialogues = Program.dialogues;
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

            sell1.Tag = 0;
            sell2.Tag = 1;
            sell3.Tag = 2;
            sell4.Tag = 3;
            sell5.Tag = 4;
            sell6.Tag = 5;
            sell7.Tag = 6;
            sell8.Tag = 7;
            sell9.Tag = 8;

            sell1.Click += new EventHandler(Sell_Click);
            sell2.Click += new EventHandler(Sell_Click);
            sell3.Click += new EventHandler(Sell_Click);
            sell4.Click += new EventHandler(Sell_Click);
            sell5.Click += new EventHandler(Sell_Click);
            sell6.Click += new EventHandler(Sell_Click);
            sell7.Click += new EventHandler(Sell_Click);
            sell8.Click += new EventHandler(Sell_Click);
            sell9.Click += new EventHandler(Sell_Click);
        }

        private void CrestfallCityForm8_Load(object sender, EventArgs e)
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
            Box.Visible = false;
            QuestButton.Visible = false;
            LocItems item1s = new LocItems();
            merch3index = item1s.Merchant3Items();
            merch3price = Program.items.merch3price;

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

            sell[0] = sell1;
            sell[1] = sell2;
            sell[2] = sell3;
            sell[3] = sell4;
            sell[4] = sell5;
            sell[5] = sell6;
            sell[6] = sell7;
            sell[7] = sell8;
            sell[8] = sell9;

            price[0] = Price1;
            price[1] = Price2;
            price[2] = Price3;
            price[3] = Price4;
            price[4] = Price5;
            price[5] = Price6;
            price[6] = Price7;
            price[7] = Price8;
            price[8] = Price9;

            printmerch3();
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
                        CrestfallCityForm5 CCF = new CrestfallCityForm5();
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
                        CrestfallCityForm10 CCF = new CrestfallCityForm10();
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
                        CrestfallCityForm9 CCF = new CrestfallCityForm9();
                        this.Hide();
                        CCF.ShowDialog();
                        this.Close();
                    }
                    break;
                }
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
            entityType = newPosition.collisionChecker(newPos, moblocation, mobnames);
            Program.items.fighting = entityType[1];
            TeleportChecker(newPos, moblocation, mobnames);
            InteractionChecker();
        }

        int[] entityType = { 0, 0 };
        private void InteractionChecker()
        {
            if (entityType[0] > 0 && entityType[0] <= 8)
            {
                Shop.Visible = false;
            }
            else if (entityType[0] == 9)
            {
                Shop.Visible = true;
            }
            else if (entityType[0] == 0)
            {
                Shop.Visible = false;
            }
            else if (entityType[0] == 13)
            {
                QuestButton.Visible = true;
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
            if (current != 0)
            {
                Program.items.itemuse(current);
            }
            printitems(starting);
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


        int[] merch3index;
        int[] merch3price;
        int buy, buying;
        private void Sell_Click(object sender, EventArgs e)
        {
            PictureBox clickedButton = sender as PictureBox;
            if (clickedButton != null)
            {
                buy = (int)clickedButton.Tag;
                buying = merch3index[buy];
                //MessageBox.Show(buy.ToString() + "   " + merch3index[buy].ToString());
            }
        }
        public void printmerch3()
        {
            for (int x = 0; x < price.Length; x++)
            {
                price[x].Text = "";
            }
            for (int x = 0; x < price.Length; x++)
            {
                if (price[x].Text == "" && merch3index[x] != 0)
                {
                    price[x].Text = merch3price[merch3index[x]].ToString();
                    sell[x].Image = assets[merch3index[x]];
                    sell[x].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            if (Buy != null)
            {
                if (Program.items.gold > merch3price[buying])
                {
                    Program.items.itemquan[buying] += 1;
                    Program.items.gold -= merch3price[buying];
                }
            }
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void mob4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentIndex < currentText.Length)
            {
                Dialogue.Text += currentText[currentIndex];
                currentIndex++;
            }
            else
            {
                timer1.Stop();
            }
        }

        string currentText;
        int currentIndex;
        private void QuestButton_Click(object sender, EventArgs e)
        {
            Box.Visible = true;
            currentIndex = 0;
            if (Program.dialogues.CSQ3 < 2 && (Program.dialogues.currentQuest == "Crest3" || Program.dialogues.currentQuest == ""))
            {
                if (Program.dialogues.CSQ3 < 1)
                {
                    if (Program.dialogues.Crest3 < 5)
                    {
                        MessageBox.Show("Complete the objective first");
                    }
                    else
                    {
                        currentText = dialogues.CCSQ3();
                        Program.dialogues.CSQ3++;
                        Program.dialogues.currentQuest = "Crest3";
                        MessageBox.Show("Quest is already finished!");
                    }
                }
                else
                {
                    currentText = dialogues.CCSQ3();
                    Program.dialogues.CSQ3++;
                    Program.dialogues.currentQuest = "Crest3";
                }

                if (Program.dialogues.CSQ3 == 2)
                {
                    Program.dialogues.currentQuest = "";
                }
            }
            else { currentText = "Quest Alrady done"; }
            Dialogue.Text = "";
            timer1.Enabled = true;
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
