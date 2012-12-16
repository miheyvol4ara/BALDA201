using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace балд
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static void bap(string[][] A, ref string[][] B)//Функция, когда B присваивается A
        {
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A[i].Length; j++)
                    B[i][j] = A[i][j];
        }
        //Функция добавления в список слов введенного слова, а также подсчет очков.
        static void listadd(ref bool player, ListBox lst1, ListBox lst2, string rts, ref int q1, ref int q2)
        {
            if (player)
            {
                lst1.Items.Add(rts);
                player = false;
                q1 += rts.Length;
            }
            else
            c Form2()
        {
            InitializeComponent();
        }
        static void bap(string[][] A, ref string[][] B)//Функция, когда B присваивается A
        {
            for (int i = 0; i < A.Length; i++)
                for (int j = 0; j < A[i].Length; j++)
                    B[i][j] = A[i][j];
        }
        //Функция добавления в список слов введе
            {
                lst2.Items.Add(rts);
                player = true;
                q2 += rts.Length;
            }
        }
    }
}
