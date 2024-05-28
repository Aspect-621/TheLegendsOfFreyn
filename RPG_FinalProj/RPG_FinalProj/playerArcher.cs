using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial1_Movement_Classes_COMPROGPROJ
{
    internal class playerArcher
    {
        public string[] archerSkills = { "Power Shot", "Volley", "Dancing Arrows", "God of wind “FUJIN”" };
        public int[] pWarriorDamage(int chosenAttack, int playerStrength, int mobArmor, int mobMR, int mobLuck, int mobEvasion, int[] Mobdebuffs, int[] playerBuffs)
        {
            Random random = new Random();
            int[] damage = { 0, 0, 0, 0, 0, 0, 0 };
            damage[0] = chosenAttack;
            if (chosenAttack == 1)
            {
                if (random.Next(1, 101) >= (mobEvasion + (mobLuck * .6)) / 2)
                {
                    if (random.Next(1, 101) >= 50 - (mobLuck * .6))
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)) * 1.5);
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                    else
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)));
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                }
                else
                {
                    damage[1] = 0;
                    damage[2] = 100;
                    damage[3] = 100;
                    damage[4] = 0;
                    damage[5] = 0;
                }
            }
            else if (chosenAttack == 2)
            {
                if (random.Next(1, 101) >= (mobEvasion + (mobLuck * .6)) / 2)
                {
                    if (random.Next(1, 101) >= 50 - (mobLuck * .6))
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)) * 1.5);
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                    else
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)));
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                }
                else
                {
                    damage[1] = 0;
                    damage[2] = 100;
                    damage[3] = 100;
                    damage[4] = 0;
                    damage[5] = 0;
                }
            }
            else if (chosenAttack == 3)
            {
                if (random.Next(1, 101) >= (mobEvasion + (mobLuck * .6)) / 2)
                {
                    if (random.Next(1, 76) >= 50 - (mobLuck * .6))
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.8f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)) * 1.5);
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                    else
                    {
                        damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 2.8f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)));
                        damage[2] = 100;
                        damage[3] = 100;
                        damage[4] = 0;
                        damage[5] = 0;
                    }
                }
                else
                {
                    damage[1] = 0;
                    damage[2] = 100;
                    damage[3] = 100;
                    damage[4] = 0;
                    damage[5] = 0;
                }
            }
            else if (chosenAttack == 4)
            {
                if (random.Next(1, 101) >= 50 - (mobLuck * .6))
                {
                    damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 3.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)) * 1.5);
                    damage[2] = 100;
                    damage[3] = 100;
                    damage[4] = 0;
                    damage[5] = 0;
                }
                else
                {
                    damage[1] = (int)(((30 + (playerStrength * (1 + (playerBuffs[0] / 100f))) * 3.3f) * ((100 - (mobArmor * (Mobdebuffs[0] / 100f))) / 100f)));
                    damage[2] = 100;
                    damage[3] = 100;
                    damage[4] = 0;
                    damage[5] = 0;
                }
            }
            return damage;
        }
    }
}
