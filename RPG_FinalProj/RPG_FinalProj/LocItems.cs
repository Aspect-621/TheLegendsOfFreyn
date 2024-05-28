using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_FinalProj
{
    internal class LocItems
    {
        public string[] itemname;
        public int[] itemquan;

        public string[] merch3name;
        public int[] merch3price;

        public int Maxhealth;
        public int[] weaponadd = { 0, 0, 0, 0, 0, 0, 0, 0 };
        public string[] merch2name;
        public int[] merch2price;

        public string[] merch1name;
        public int[] merch1price;

        public int[] itemusedStats = {0,0,0,0,0,0,0,0};
        public int gold;
        public int currentForm;
        public int fighting;
        public int winorlose;
        public int[] playerstats;
        public int playerHealth;
        public string[] name1 = { "3", "Empty Pot", "Full Pot", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "12", "13", "14", "15" };
        public int[] quan1 = { 0, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public int[] merchant3price = {0, 700, 150, 500, 2000, 1700, 0, 0, 0, 2500, 0, 0, 0, 2500, 0, 0, 0, 4000, 2500, 0 };

        public int[] merchant2price = {0, 700, 150, 500, 2000, 0, 2000, 0, 2300, 0, 1900, 0, 0, 0, 3000, 0, 4000, 0, 0, 0  };

        public int[] merchant1price = {0, 700, 150, 500, 2000, 0, 0, 1800, 0, 0, 0, 3000, 0, 2700, 0, 2800, 0, 0, 0, 3000 };
        public int[] location;
        public int classSelected = 2;
        public int enemyChosen;

        public LocItems()
        {

            merch1price = merchant1price;
            merch2price = merchant2price;
            merch3price = merchant3price;
            itemname = name1;
            itemquan = quan1;
            enemyChosen = 1;
            gold = 100;
            playerstats = new int[8];
            location = new int[2];
            location[0] = 123;
            location[1] = 409;
        }

        public int[] location1
        {
            get { return location; }
            set { location = value; }
        }
        public string[] name
        {
            get { return itemname; }
            set { itemname = value; }
        }

        public int[] quan
        {
            get { return itemquan; }
            set { itemquan = value; }
        }

        public void saleValidation1(int gold, int x)
        {
            if (gold > merchant1price[x])
            {

            }
        }
        public void setlocation(int index, int value)
        {
            location1[index] = value;
        }
        public void Setquest1(int index, string value)
        {
            name[index] = value;
        }

        public void setstats(int index, int value)
        {
            playerstats[index] = value;
            if (index == 7)
            {
                playerHealth = playerstats[7] * 15 + 300;
                Maxhealth = playerHealth;
            }
        }

        public void addstats(string operation, int[] value)
        {
            if (operation == "add")
            {
                for (int i = 0; i < playerstats.Length; i++)
                {
                    playerstats[i] += value[i];
                }

            }
            else if (operation == "minus")
            {
                for (int i = 0; i < playerstats.Length; i++)
                {
                    playerstats[i] -= value[i];
                }
            }

        }
        public void itemuse(int item)
        {
            Random random = new Random();
            if (itemquan[item] != 0)
            {
                if (item == 0)
                {
                    playerstats[random.Next(0, 7)] += 15;
                }
                else if (item == 1)
                {
                    playerHealth += 300;
                }
                else if (item == 2)
                {
                    playerstats[7] += 10;
                    playerHealth = playerstats[7] * 20 + 200;

                }
                else if (item == 3)
                {
                    for (int x = 0; x < playerstats.Length; x++)
                    {
                        playerstats[x] += 5;
                    }
                }
                else if (item == 4)
                {
                    int[] itemadd = { 5, 0, 20, 10, 15, 5, 10, 10 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 5)
                {
                    int[] itemadd = { 10, 0, 40, 20, 30, 10, 10, 15 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 6)
                {
                    int[] itemadd = { 5, 0, 5, 0, 10, 10, 10, 10 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 7)
                {
                    int[] itemadd = { 0, 30, 10, 10, 15, 15, 15, 40 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 8)
                {
                    int[] itemadd = { 0, 50, 10, 30, 15, 15, 10, 10 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 9)
                {
                    int[] itemadd = { 15, 15, 15, 15, 10, 10, 10, 10 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 10)
                {
                    int[] itemadd = { 25, 0, 50, 50, 25, 5, 10, 40 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 11)
                {
                    int[] itemadd = { 15, 15, 15, 15, 10, 10, 10, 10 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 12)
                {
                    int[] itemadd = { 20, 0, 0, 0, 40, 10, 10, 0 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 13)
                {
                    int[] itemadd = { 50, 0, 0, 0, 10, 10, 10, 0 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 14)
                {
                    int[] itemadd = { 0, 50, 0, 0, 10, 10, 10, 0 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 15)
                {
                    int[] itemadd = { 20, 0, 0, 0, 60, 10, 10, 0 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 16)
                {
                    int[] itemadd = { 0, 70, 0, 0, 10, 10, 10, 0 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 17)
                {
                    int[] itemadd = { 50, 0, 0, 0, 10, 10, 10, 20 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 18)
                {
                    int[] itemadd = { 10, 0, 0, 0, 10, 40, 40, 20 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                else if (item == 19)
                {
                    int[] itemadd = { 50, 0, 0, 0, 10, 10, 10, 20 };
                    addstats("minus", itemusedStats);
                    itemusedStats = itemadd;
                    addstats("add", itemusedStats);
                }
                if (item < 4)
                {
                    itemquan[item]--;
                }
            }
        }
        public int[] availableItems()
        {
            int[] availableItem = new int[15];
            int[] itemindex = new int[20];
            for (int i = 0; i < itemname.Length; i++)
            {
                if (itemquan[i] != 0)
                {
                    for (int x = 0; x < itemname.Length; x++)
                    {
                        if (itemindex[0] == 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                        else if (itemindex[x] == 0 && x != 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                    }
                }
            }
            return itemindex;
        }

        public int[] Merchant3Items()
        {
            int[] itemindex = new int[20];
            for (int i = 0; i < itemname.Length; i++)
            {
                if (merch3price[i] != 0)
                {
                    for (int x = 0; x < itemname.Length; x++)
                    {
                        if (itemindex[0] == 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                        else if (itemindex[x] == 0 && x != 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                    }
                }
            }
            return itemindex;
        }

        public int[] Merchant2Items()
        {
            int[] itemindex = new int[20];
            for (int i = 0; i < itemname.Length; i++)
            {
                if (merch2price[i] != 0)
                {
                    for (int x = 0; x < itemname.Length; x++)
                    {
                        if (itemindex[0] == 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                        else if (itemindex[x] == 0 && x != 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                    }
                }
            }
            return itemindex;
        }

        public int[] Merchant1Items()
        {
            int[] itemindex = new int[20];
            for (int i = 0; i < itemname.Length; i++)
            {
                if (merch1price[i] != 0)
                {
                    for (int x = 0; x < itemname.Length; x++)
                    {
                        if (itemindex[0] == 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                        else if (itemindex[x] == 0 && x != 0)
                        {
                            itemindex[x] = i;
                            break;
                        }
                    }
                }
            }
            return itemindex;
        }

    }
}
