using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trial1_Movement_Classes_COMPROGPROJ
{
    public class Puzzle1
    {
        

        public int[] turn(int choice, int[] puzzlenums)
        {
            if (choice == 1)
            {
                puzzlenums[0]++;
                puzzlenums[1]++;
                puzzlenums[3]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 2)
            {
                puzzlenums[0]++;
                puzzlenums[1]++;
                puzzlenums[2]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 3)
            {
                puzzlenums[1]++;
                puzzlenums[2]++;
                puzzlenums[5]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 4)
            {
                puzzlenums[0]++;
                puzzlenums[3]++;
                puzzlenums[4]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 5)
            {
                puzzlenums[5]++;
                puzzlenums[3]++;
                puzzlenums[4]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 6)
            {
                puzzlenums[5]++;
                puzzlenums[2]++;
                puzzlenums[4]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 7)
            {
                puzzlenums[1]++;
                puzzlenums = checknum(puzzlenums);
            }
            else if (choice == 8)
            {
                puzzlenums[4]++;
                puzzlenums = checknum(puzzlenums);
            }
            return puzzlenums;
        }
        public int[] checknum(int[] puzzlenums)
        {
            for (int x = 0; x < puzzlenums.GetLength(0); x++)
            {
                if (puzzlenums[x] == 5)
                {
                    puzzlenums[x] = 1;
                }
            }
            return puzzlenums;
        }

        public int checkWin(int[] puzzlenums)
        {
            if (puzzlenums[0] == puzzlenums[1] && puzzlenums[2] == puzzlenums[1] && puzzlenums[3] == puzzlenums[1] && puzzlenums[4] == puzzlenums[3]) { return 1; }
            else { return 0; }
        }
    }

    
}
