using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class Sudoku_Coz
    {
        public bool Coz(int[,] sudoku,int i, int j)
        {
            if (i == 9)
            {
                i = 0;
                if (++j == 9)
                {
                    return true;
                }
            }

            if (sudoku[i, j] != 0)
            {
                return Coz(sudoku, i + 1, j);
            }

            for (int kontrol = 1; kontrol <= 9; kontrol++)
            {
                if (Kontrol(sudoku, kontrol,i, j))
                {
                    sudoku[i, j] = kontrol;
                    if (Coz(sudoku, i + 1, j))
                    {
                        return true;
                    }
                }
            }

            sudoku[i, j] = 0; 

            return false;
        }

        private bool Kontrol(int[,] sudoku,int kontrol,int satir, int sutun)
        {
            for (int k = 0; k < 9; k++)
            {
                if (kontrol == sudoku[satir, k])
                {
                    return false;
                }
            }

            for (int k = 0; k < 9; k++)
            {
                if (kontrol == sudoku[k, sutun])
                {
                    return false;
                }
            }

            int bolgesatir = (satir / 3) * 3;
            int bolgesutun = (sutun / 3) * 3;

            for (int k = 0; k < 3; k++)
            {
                for (int m = 0; m < 3; m++)
                {
                    if (kontrol == sudoku[bolgesatir + k, bolgesutun + m])
                    {
                        return false;
                    }
                }
            }

            return true; 
        }
    }
}
