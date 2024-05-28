using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial1_Movement_Classes_COMPROGPROJ;

namespace RPG_FinalProj
{
    public partial class CrestfallCityForm2 : Form
    {
        private readonly LocItems _items;
        private readonly quest1Dialogue dialogues;
        int[,] obstacles = new int[58, 4];
        PictureBox[] obstacle = new PictureBox[58];
        PictureBox[] mob = new PictureBox[3];
        int[,] moblocation = new int[3, 4];
        string[] mobnames = new string[3];
        Label[] itemlb = new Label[9];
        PictureBox[] item = new PictureBox[9];

        PictureBox[] sell = new PictureBox[9];
        Label[] price = new Label[9];
        public CrestfallCityForm2()
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
                        CrestfallCityForm3 CCF = new CrestfallCityForm3();
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
                        CrestfallCityForm3 CCF = new CrestfallCityForm3();
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

        private void CrestfallCityForm2_Load(object sender, EventArgs e)
        {
            Box.Visible = false;
            QuestButton.Visible = false;
            LocItems item1s = new LocItems();
            merch3index = item1s.Merchant2Items();
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

        private void CrestfallCity_KeyDown_1(object sender, KeyEventArgs e)
        {
            int leftPosition, topPosition, rightPosition, bottomPosition;
            int[] movement = { 0, 0, 0, 0 };
            leftPosition = Player.Location.X;
            topPosition = Player.Location.Y;
            rightPosition = Player.Location.X + Player.Size.Width;
            bottomPosition = Player.Location.Y + Player.Size.Height;
            int keypressed = (int)e.KeyCode;
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
            QuestButton.Visible = false;
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
            else if (entityType[0] == 11)
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
            for (int x = 0; x < item.Length; x++)
            {
                itemlb[x].Text = "";
                item[x].BackColor = Color.White;
            }
            for (int x = 0; x < itemlb.Length; x++)
            {
                if (itemlb[x].Text == "" && itemindex[x + starting] != 0)
                {
                    itemlb[x].Text = itemquan[itemindex[x + starting]].ToString();
                    item[x].BackColor = Color.Black;
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
                select1.Text = itemquan[current].ToString();
            }
        }

        private void UseItem_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show(buy.ToString() + "   " + merch3index[buy].ToString());
            }
        }
        public void printmerch3()
        {
            for (int x = 0; x < price.Length; x++)
            {
                price[x].Text = "";
                sell[x].BackColor = Color.White;
            }
            for (int x = 0; x < price.Length; x++)
            {
                if (price[x].Text == "" && merch3index[x] != 0)
                {
                    price[x].Text = merch3price[merch3index[x]].ToString();
                    sell[x].BackColor = Color.Black;
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

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        string currentText;
        int currentIndex;
        private void pictureBox60_Click(object sender, EventArgs e)
        {
            Box.Visible = true;
            currentIndex = 0;
            if (Program.dialogues.CSQ1 < 2 && (Program.dialogues.currentQuest == "Crest1" || Program.dialogues.currentQuest == ""))
            {
                if (Program.dialogues.CSQ1 == 1)
                {
                    if (Program.dialogues.Crest1 == false)
                    {
                        MessageBox.Show("completer the objective first");
                    }
                    else
                    {
                        currentText = dialogues.CCSQ1();
                        Program.dialogues.CSQ1++;
                        Program.dialogues.currentQuest = "Crest1";
                        MessageBox.Show("Tapos na yung quest");
                    }
                }
                else
                {
                    currentText = dialogues.CCSQ1();
                    Program.dialogues.CSQ1++;
                    Program.dialogues.currentQuest = "Crest1";
                }

                if (Program.dialogues.CSQ1 == 2)
                {
                    Program.dialogues.currentQuest = "";
                }
            }
            else if (Program.dialogues.CSQ1 == 2) { currentText = "Quest is already done";}
            else { currentText = "There is Quest On Going"; }
            Dialogue.Text = "";
            timer1.Enabled = true;
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
    }
}
