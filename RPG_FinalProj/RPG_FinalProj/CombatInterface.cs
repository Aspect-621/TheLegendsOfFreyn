using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trial1_Movement_Classes_COMPROGPROJ;

namespace RPG_FinalProj
{
    public partial class CombatInterface : Form
    {
        Random random = new Random();
        Form[] forms = new Form[20];
        private readonly LocItems _items;
        private readonly quest1Dialogue dialogues;
        public CombatInterface()
        {
            InitializeComponent();
            _items = Program.items;
            dialogues = Program.dialogues;
        }

        int chosenskill = 0;
        int special = 1;
        int ultimate = 2;
        int[] playerdebuff = { 100, 100 };
        int[] mobdebuff = { 100, 100 };
        int[] playerbuff = { 0, 0 };
        int[] mobbuff = { 0, 0 };

        int[] playerstats;
        int[] mobstats = { 30, 30, 30, 30, 30, 30, 30 };

        string[] mobSkills, playerSkill;
        int mobskill = 1;

        int chosenClass;
        int enemy = 3;

        public int playerHealth;
        public int mobHealth = 1000;
        private void CombatInterface_Load(object sender, EventArgs e)
        {
            chosenClass = Program.items.classSelected;
            forms[0] = new JuraForestForm1();
            forms[1] = new JuraForestForm2();
            forms[2] = new JuraForestForm3();
            forms[3] = new JuraForestForm4();
            forms[4] = new JuraForestForm5();
            forms[5] = new JuraForestForm6();
            forms[6] = new JuraForestForm7();
            forms[7] = new JuraForestForm8();
            forms[8] = new JuraForestForm9();
            forms[9] = new JuraForestCave();
            forms[10] = new CrestfallCityForm1();
            forms[11] = new CrestfallCityForm2();
            forms[12] = new CrestfallCityForm3();
            forms[13] = new CrestfallCityForm4();
            forms[14] = new CrestfallCityForm5();
            forms[15] = new CrestfallCityForm6();
            forms[16] = new CrestfallCityForm7();
            forms[17] = new CrestfallCityForm8();
            forms[18] = new CrestfallCityForm9();
            forms[19] = new CrestfallCityForm10();
            enemy = Program.items.enemyChosen;
            playerstats = Program.items.playerstats;
            Goblin goblin = new Goblin();
            Ogre ogre = new Ogre();
            Wolves wolf = new Wolves();
            Werewolf WW = new Werewolf();
            Undead dead = new Undead();
            Gargoyle bato = new Gargoyle();
            playerWarrior PW = new playerWarrior();
            playerArcher PA = new playerArcher();
            playerMage PM = new playerMage();
            Skeleton skeleton = new Skeleton();
            Slime slime = new Slime();
            Slime_King SK = new Slime_King();
            DemonQueen DQ = new DemonQueen();
            DemonKing DK = new DemonKing();
            if (enemy == 1)
            {
                mobSkills = goblin.goblinSkills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(25, 35);
                    mobHealth = mobstats[6] * 7 + 200;
                    EnemyPic.Image = Properties.Resources.goblin_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 2)
            {
                mobSkills = ogre.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(40, 50);
                    mobHealth = mobstats[6] * 10 + 300;
                    EnemyPic.Image = Properties.Resources.ogre_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 3)
            {
                mobSkills = wolf.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(30, 40); 
                    mobHealth = mobstats[6] * 8 + 300;
                    EnemyPic.Image = Properties.Resources.wolf_attack;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 4)
            {
                mobSkills = WW.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(45, 55);
                    mobHealth = mobstats[6] * 10 + 300;
                    EnemyPic.Image = Properties.Resources.warewolf_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 5)
            {
                mobSkills = dead.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(35, 45);
                    mobHealth = mobstats[6] * 10 + 200;
                    EnemyPic.Image = Properties.Resources.Un_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 6)
            {
                mobSkills = bato.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(60, 65);
                    mobHealth = mobstats[6] * 15 + 300;
                    EnemyPic.Image = Properties.Resources.gorgoyle_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 7)
            {
                mobSkills = skeleton.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(45, 50);
                    mobHealth = mobstats[6] * 8 + 200;
                    EnemyPic.Image = Properties.Resources.skeleton_attack;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 8)
            {
                mobSkills = slime.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(10, 20);
                    mobHealth = mobstats[6] * 4 + 300;
                    EnemyPic.Image = Properties.Resources.GreenSlime_idle;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (enemy == 9)
            {
                mobSkills = SK.Skills;
                for (int x = 0; x < 7; x++)
                {
                    mobstats[x] = random.Next(80,85);
                    mobHealth = mobstats[6] * 10 + 300;
                    EnemyPic.Image = Properties.Resources.slimeKingAttack;
                    EnemyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            if (chosenClass == 1)
            {
                playerSkill = PW.warriorSkills;
                Player.Image = Properties.Resources.sword_attack_right;
            }
            else if (chosenClass == 2)
            {
                playerSkill = PA.archerSkills;
                Player.Image = Properties.Resources.Archer_attack_right;
            }
            else if (chosenClass == 3)
            {
                playerSkill = PM.mageSkills;
                Player.Image = Properties.Resources.mage_atttack_rigth;
            }

            radioButton1.Text = playerSkill[0];
            radioButton2.Text = playerSkill[1];
            radioButton3.Text = playerSkill[2];
            radioButton4.Text = playerSkill[3];
            checkCD();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            playerstats[0] = 100;
            int[] Pdamage = { 0, 0, 0, 0, 0, 0, 0, 0 }, Gdamage = { 0, 0, 0, 0, 0, 0, 0, 0 };
            Goblin goblin = new Goblin();
            Ogre ogre = new Ogre();
            Wolves wolf = new Wolves();
            Werewolf WW = new Werewolf();
            Undead dead = new Undead();
            Gargoyle bato = new Gargoyle();
            Skeleton skeleton = new Skeleton();
            Slime slime = new Slime();
            Slime_King SK = new Slime_King();
            DemonQueen DQ = new DemonQueen();
            DemonKing DK = new DemonKing();
            playerWarrior PW = new playerWarrior();
            playerArcher PA = new playerArcher();
            playerMage PM = new playerMage();
            if (radioButton1.Checked == true) { chosenskill = 1; }
            else if (radioButton2.Checked == true) { chosenskill = 2; }
            else if (radioButton3.Checked == true) { chosenskill = 3; }
            else if (radioButton4.Checked == true) { chosenskill = 4; }
            else { MessageBox.Show("click a radio button"); chosenskill = 0; }

            if (chosenskill != 0)
            {
                if (chosenClass == 1)
                {
                    Pdamage = PW.pWarriorDamage(chosenskill, playerstats[0], mobstats[2], mobstats[3], mobstats[5], mobstats[6], mobdebuff, playerbuff);
                }
                else if (chosenClass == 2)
                {
                    Pdamage = PA.pWarriorDamage(chosenskill, playerstats[0], mobstats[2], mobstats[3], mobstats[5], mobstats[6], mobdebuff, playerbuff);
                    Pdamage[1] += (int)(Program.items.playerstats[4] * 2.5);
                }
                else if (chosenClass == 3)
                {
                    Pdamage = PM.pWarriorDamage(chosenskill, playerstats[1], mobstats[2], mobstats[3], mobstats[5], mobstats[6], mobdebuff, playerbuff);
                    Pdamage[1] += (int)(Program.items.playerstats[1] * 2);
                }

                if (Pdamage[0] == 3)
                {
                    special = 2;
                    chosenskill = 0;
                    radioButton3.Checked = false;
                }
                else if (Pdamage[0] == 4)
                {
                    ultimate = 3;
                    chosenskill = 0;
                    radioButton4.Checked = false;
                }

                if (enemy == 1)
                {
                    Gdamage = goblin.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 2)
                {
                    Gdamage = ogre.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 3)
                {
                    Gdamage = wolf.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 4)
                {
                    Gdamage = WW.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 5)
                {
                    Gdamage = dead.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 6)
                {
                    Gdamage = bato.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 7)
                {
                    Gdamage = skeleton.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 8)
                {
                    Gdamage = slime.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 9)
                {
                    Gdamage = SK.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 10)
                {
                    Gdamage = DQ.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }
                else if (enemy == 11)
                {
                    Gdamage = DK.Attack(mobskill, mobstats[0], playerstats[2], playerstats[3], playerstats[5], playerstats[6], playerdebuff, mobbuff);
                }

                mobHealth -= Pdamage[1];
                mobHealth -= Pdamage[6];
                Program.items.playerHealth -= Gdamage[1];
                Program.items.playerHealth -= Gdamage[6];
                printdamage(1, Pdamage);
                printdamage(2, Gdamage);
                playerbuff[0] = Pdamage[4];
                playerbuff[1] = Pdamage[5];
                playerdebuff[0] = Gdamage[2];
                playerdebuff[1] = Gdamage[3];
                mobbuff[0] = Gdamage[4];
                mobbuff[1] = Gdamage[5];
                mobdebuff[0] = Pdamage[2];
                mobdebuff[1] = Pdamage[3];
                reduceCD();
                checkCD();
                checkHealth();
            }
            mobskill++;
        }

        private void checkCD()
        {
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            if (special != 0)
            {
                radioButton3.Enabled = false;
            }

            if (ultimate != 0)
            {
                radioButton4.Enabled = false;
            }
        }

        private void reduceCD()
        {
            if (special != 0)
            {
                special--;
            }

            if (ultimate != 0)
            {
                ultimate--;
            }
        }

        public void checkHealth()
        {
            if (Program.items.playerHealth < 0)
            {
                MessageBox.Show("\tYou Lost! \n\nRespawning in Jura Forest Village...");
                JuraForestForm7 JJF = new JuraForestForm7();
                Program.items.location[0] = 720;
                Program.items.location[1] = 100;
                this.Hide();
                JJF.ShowDialog();
                this.Close();
                Program.items.winorlose = 0;

            }

            if (mobHealth < 0)
            {
                Program.items.winorlose = 1;
                MessageBox.Show("You won!");
                this.Hide();
                forms[Program.items.currentForm].ShowDialog();
                this.Close();

                if (Program.dialogues.currentQuest == "Jura1")
                {
                    if (enemy == 8)
                    {
                        Program.dialogues.Jura1[0]++;
                    }
                    else if (enemy == 3)
                    {
                        Program.dialogues.Jura1[1]++;
                    }
                }
                else if (Program.dialogues.currentQuest == "Crest2")
                {
                    if (enemy == 2)
                    {
                        Program.dialogues.Crest2++;
                    }
                }
                else if (Program.dialogues.currentQuest == "Crest3")
                {
                    if (enemy == 1)
                    {
                        Program.dialogues.Crest2++;
                    }
                }
                else if (Program.dialogues.currentQuest == "Crest4")
                {
                    if (enemy == 1)
                    {
                        Program.dialogues.Crest4[0]++;
                    }
                    else if (enemy == 2)
                    {
                        Program.dialogues.Crest4[1]++;
                    }
                    else if (enemy == 3)
                    {
                        Program.dialogues.Crest4[2]++;
                    }
                    else if (enemy == 8)
                    {
                        Program.dialogues.Crest4[3]++;
                    }
                    else if (enemy == 7)
                    {
                        Program.dialogues.Crest4[4]++;
                    }
                }


                if (enemy == 1)
                {
                    Program.items.gold += random.Next(150, 180);
                }
                else if (enemy == 2)
                {
                    Program.items.gold += random.Next(170, 200);
                }
                else if (enemy == 3)
                {
                    Program.items.gold += random.Next(140, 170);
                }
                else if (enemy == 4)
                {
                    Program.items.gold += random.Next(250, 270);
                }
                else if (enemy == 5)
                {
                    Program.items.gold += random.Next(140, 170);
                }
                else if (enemy == 6)
                {
                    Program.items.gold += random.Next(300, 330);
                }
                else if (enemy == 7)
                {
                    Program.items.gold += random.Next(140, 170);
                }
                else if (enemy == 8)
                {
                    Program.items.gold += random.Next(80, 100);
                }
                else if (enemy == 9)
                {
                    Program.items.gold += 1500;
                }
                else if (enemy == 10)
                {
                    Program.items.gold += 3000;
                }
                else if (enemy == 11)
                {
                    Program.items.gold += 5000;
                }
            }
        }

        private void printdamage(int x, int[] damage)
        {
            if (x == 1)
            {
                label1.Text = "Attack Selected " + playerSkill[damage[0]-1] + "\n" + damage[1].ToString() + "---" + Program.items.playerHealth.ToString();
                if (damage[6] != 0)
                {
                    label1.Text += "\n additional Damage " + damage[6].ToString();
                }
            }
            else if (x == 2)
            {
                label2.Text = "Attack Selected " + mobSkills[damage[7]] + "\n" + damage[1].ToString() + "---" + mobHealth.ToString();
                if (damage[6] != 0)
                {
                    label2.Text += "\n additional Damage" + damage[6].ToString();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
