using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_FinalProj
{
    internal class MovementPlayer
    {
        public int[] Movement(int x, int y, int right, int bottom, int keypressed, int[,] obstacles)
        {
            int[] newPosition = new int[4];
            newPosition[0] = x;
            newPosition[1] = y;
            newPosition[2] = right;
            newPosition[3] = bottom;
            switch (keypressed)
            {
                case 87:
                    newPosition[1] -= 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[1] == obstacles[i, 3] || newPosition[1] == obstacles[i, 3] + 1 || newPosition[1] == obstacles[i, 3] + 2 || newPosition[1] == obstacles[i, 3] + 3 || newPosition[1] == obstacles[i, 3] + 4 || newPosition[1] == obstacles[i, 3] + 5) &&
                           ((newPosition[0] > obstacles[i, 0] && newPosition[2] < obstacles[i, 2]) ||
                           (newPosition[0] <= obstacles[i, 0] && newPosition[2] >= obstacles[i, 0]) ||
                           (newPosition[2] >= obstacles[i, 2] && newPosition[0] <= obstacles[i, 2])))
                        {
                            newPosition[1] += 5;
                            break;
                        }
                    }
                    break;
                case 65:
                    newPosition[0] -= 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[0] == obstacles[i, 2] || newPosition[0] == obstacles[i, 2] + 1 || newPosition[0] == obstacles[i, 2] + 2 || newPosition[0] == obstacles[i, 2] + 3 || newPosition[0] == obstacles[i, 2] + 4 || newPosition[0] == obstacles[i, 2] + 5) &&
                           ((newPosition[1] > obstacles[i, 1] && newPosition[3] < obstacles[i, 3]) ||
                           (newPosition[1] <= obstacles[i, 1] && newPosition[3] >= obstacles[i, 1]) ||
                           (newPosition[3] >= obstacles[i, 3] && newPosition[1] <= obstacles[i, 3])))
                        {
                            newPosition[0] += 5;
                            break;
                        }
                    }

                    break;
                case 83:
                    newPosition[1] += 5;
                    newPosition[3] += 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[3] == obstacles[i, 1] || newPosition[3] == obstacles[i, 1] + 1 || newPosition[3] == obstacles[i, 1] + 2 || newPosition[3] == obstacles[i, 1] + 3 || newPosition[3] == obstacles[i, 1] + 4 || newPosition[3] == obstacles[i, 1] + 5) &&
                           ((newPosition[0] > obstacles[i, 0] && newPosition[2] < obstacles[i, 2]) ||
                           (newPosition[0] <= obstacles[i, 0] && newPosition[2] >= obstacles[i, 0]) ||
                           (newPosition[2] >= obstacles[i, 2] && newPosition[0] <= obstacles[i, 2])))
                        {
                            newPosition[1] -= 5;
                            break;
                        }
                    }
                    break;
                case 68:
                    newPosition[0] += 5;
                    newPosition[2] += 5;
                    for (int i = 0; i < obstacles.GetLength(0); i++)
                    {
                        if ((newPosition[2] == obstacles[i, 0] || newPosition[2] == obstacles[i, 0] + 1 || newPosition[2] == obstacles[i, 0] + 2 || newPosition[2] == obstacles[i, 0] + 3 || newPosition[2] == obstacles[i, 0] + 4 || newPosition[2] == obstacles[i, 0] + 5) &&
                           ((newPosition[1] > obstacles[i, 1] && newPosition[3] < obstacles[i, 3]) ||
                           (newPosition[1] <= obstacles[i, 1] && newPosition[3] >= obstacles[i, 1]) ||
                           (newPosition[3] >= obstacles[i, 3] && newPosition[1] <= obstacles[i, 3])))
                        {
                            newPosition[0] -= 5;
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
            return newPosition;
        }

        public int[] collisionChecker( int[] newPosition, int[,] moblocation, string[] mob)
        {
            for (int i = 0; i < moblocation.GetLength(0); i++)
            {
                if ((newPosition[1] <= moblocation[i, 3] + 5 && newPosition[1] >= moblocation[i, 1] - 5) &&
                    ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                    (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                    (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "Goblin")
                    {
                        return new int[] { 1, i };
                    }
                    else if (mob[i] == "Ogre")
                    {
                        return new int[] { 2, i };
                    }
                    else if (mob[i] == "wolf")
                    {
                        return new int[] { 3, i };
                    }
                    else if (mob[i] == "Werewolf")
                    {
                        return new int[] { 4, i };
                    }
                    else if (mob[i] == "Undead")
                    {
                        return new int[] { 5, i };
                    }
                    else if (mob[i] == "Gargoyle")
                    {
                        return new int[] { 6, i };
                    }
                    else if (mob[i] == "Skeleton")
                    {
                        return new int[] { 7, i };
                    }
                    else if (mob[i] == "Slime")
                    {
                        return new int[] { 8, i };
                    }
                    else if (mob[i] == "Merchant")
                    {
                        return new int[] { 9, i };
                    }
                    else if (mob[i] == "Jura1")
                    {
                        return new int[] { 10, i };
                    }
                    else if (mob[i] == "Crest1")
                    {
                        return new int[] { 11, i };
                    }
                    else if (mob[i] == "Crest2")
                    {
                        return new int[] { 12, i };
                    }
                    else if (mob[i] == "Crest3")
                    {
                        return new int[] { 13, i };
                    }
                    else if (mob[i] == "Crest4")
                    {
                        return new int[] { 14, i };
                    }


                    break;
                }

                else if (newPosition[0] <= moblocation[i, 2] + 5 && newPosition[0] >= moblocation[i, 0] - 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "Goblin")
                    {
                        return new int[] { 1, i };
                    }
                    else if (mob[i] == "Ogre")
                    {
                        return new int[] { 2, i };
                    }
                    else if (mob[i] == "wolf")
                    {
                        return new int[] { 3, i };
                    }
                    else if (mob[i] == "Werewolf")
                    {
                        return new int[] { 4, i };
                    }
                    else if (mob[i] == "Undead")
                    {
                        return new int[] { 5, i };
                    }
                    else if (mob[i] == "Gargoyle")
                    {
                        return new int[] { 6, i };
                    }
                    else if (mob[i] == "Skeleton")
                    {
                        return new int[] { 7, i };
                    }
                    else if (mob[i] == "Slime")
                    {
                        return new int[] { 8, i };
                    }
                    else if (mob[i] == "Merchant")
                    {
                        return new int[] { 9, i };
                    }
                    else if (mob[i] == "Jura1")
                    {
                        return new int[] { 10, i };
                    }
                    else if (mob[i] == "Crest1")
                    {
                        return new int[] { 11, i };
                    }
                    else if (mob[i] == "Crest2")
                    {
                        return new int[] { 12, i };
                    }
                    else if (mob[i] == "Crest3")
                    {
                        return new int[] { 13, i };
                    }
                    else if (mob[i] == "Crest4")
                    {
                        return new int[] { 14, i };
                    }
                }

                else if (newPosition[3] >= moblocation[i, 1] - 5 && newPosition[3] <= moblocation[i, 3] + 5 &&
                   ((newPosition[0] > moblocation[i, 0] && newPosition[2] < moblocation[i, 2]) ||
                   (newPosition[0] <= moblocation[i, 0] && newPosition[2] >= moblocation[i, 0]) ||
                   (newPosition[2] >= moblocation[i, 2] && newPosition[0] <= moblocation[i, 2])))
                {
                    if (mob[i] == "Goblin")
                    {
                        return new int[] { 1, i };
                    }
                    else if (mob[i] == "Ogre")
                    {
                        return new int[] { 2, i };
                    }
                    else if (mob[i] == "wolf")
                    {
                        return new int[] { 3, i };
                    }
                    else if (mob[i] == "Werewolf")
                    {
                        return new int[] { 4, i };
                    }
                    else if (mob[i] == "Undead")
                    {
                        return new int[] { 5, i };
                    }
                    else if (mob[i] == "Gargoyle")
                    {
                        return new int[] { 6, i };
                    }
                    else if (mob[i] == "Skeleton")
                    {
                        return new int[] { 7, i };
                    }
                    else if (mob[i] == "Slime")
                    {
                        return new int[] { 8, i };
                    }
                    else if (mob[i] == "Merchant")
                    {
                        return new int[] { 9, i };
                    }
                    else if (mob[i] == "Jura1")
                    {
                        return new int[] { 10, i };
                    }
                    else if (mob[i] == "Crest1")
                    {
                        return new int[] { 11, i };
                    }
                    else if (mob[i] == "Crest2")
                    {
                        return new int[] { 12, i };
                    }
                    else if (mob[i] == "Crest3")
                    {
                        return new int[] { 13, i };
                    }
                    else if (mob[i] == "Crest4")
                    {
                        return new int[] { 14, i };
                    }
                    break;
                }

                else if (newPosition[2] >= moblocation[i, 0] - 5 && newPosition[2] <= moblocation[i, 2] + 5 &&
                   ((newPosition[1] > moblocation[i, 1] && newPosition[3] < moblocation[i, 3]) ||
                   (newPosition[1] <= moblocation[i, 1] && newPosition[3] >= moblocation[i, 1]) ||
                   (newPosition[3] >= moblocation[i, 3] && newPosition[1] <= moblocation[i, 3])))
                {
                    if (mob[i] == "Goblin")
                    {
                        return new int[] { 1, i };
                    }
                    else if (mob[i] == "Ogre")
                    {
                        return new int[] { 2, i };
                    }
                    else if (mob[i] == "wolf")
                    {
                        return new int[] { 3, i };
                    }
                    else if (mob[i] == "Werewolf")
                    {
                        return new int[] { 4, i };
                    }
                    else if (mob[i] == "Undead")
                    {
                        return new int[] { 5, i };
                    }
                    else if (mob[i] == "Gargoyle")
                    {
                        return new int[] { 6, i };
                    }
                    else if (mob[i] == "Skeleton")
                    {
                        return new int[] { 7, i };
                    }
                    else if (mob[i] == "Slime")
                    {
                        return new int[] { 8, i };
                    }
                    else if (mob[i] == "Merchant")
                    {
                        return new int[] { 9, i };
                    }
                    else if (mob[i] == "Jura1")
                    {
                        return new int[] { 10, i };
                    }
                    else if (mob[i] == "Crest1")
                    {
                        return new int[] { 11, i };
                    }
                    else if (mob[i] == "Crest2")
                    {
                        return new int[] { 12, i };
                    }
                    else if (mob[i] == "Crest3")
                    {
                        return new int[] { 13, i };
                    }
                    else if (mob[i] == "Crest4")
                    {
                        return new int[] { 14, i };
                    }
                    break;
                }
            }
            return new int[] { 0, 0 };
        }
    }
}
