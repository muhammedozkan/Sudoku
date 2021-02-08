using System;
using System.Collections.Generic;
using System.Text;

namespace Sudoku
{
    class Sudoku_Kontrol
    {
        //*************************************
        //***********Muhammed Özkan************
        //****muhammedozkan@windowslive.com****
        //*************************************
        private bool Satir_Kontrol(int[,] sudoku, int satir, int kontrol)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[satir, j] == kontrol)
                {
                    return false;
                }
            }
            return true;
        }

        private bool Sutun_Kontrol(int[,] sudoku, int sutun, int kontrol)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[i, sutun] == kontrol)
                {
                    return false;
                }
            }
            return true;
        }

        private bool Bolge_Kontrol(int[,] sudoku, int satir, int sutun, int kontrol)
        {

            for (int i = satir - (satir % 3); i < (satir - (satir % 3)) + 3; i++)
            {
                for (int j = sutun - (sutun % 3); j < (sutun - (sutun % 3)) + 3; j++)
                {
                    if (sudoku[i, j] == kontrol)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool Ekleme_Izın(int[,] sudoku, int satir, int sutun, int kontrol)
        {
            if (Sutun_Kontrol(sudoku, sutun, kontrol) && Satir_Kontrol(sudoku, satir, kontrol) && Bolge_Kontrol(sudoku, satir, sutun, kontrol))
            {
                return true;
            }
            return false;
        }
        //*************************************
        //***********Muhammed Özkan************
        //****muhammedozkan@windowslive.com****
        //*************************************
    }
}
