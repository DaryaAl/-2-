using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LibMas
{
    public class Class2
    {
       //Параметры:
       //Входные:
       //DataGridView table - таблица
       //TextBox textBox1 - форма для вывода ответа
       //Выходные:
       //sum - значение функции
        public static void Summ(DataGridView table, TextBox textBox1)
        {
            int x, sum=0;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                x = Convert.ToInt32(table[i, 0].Value);
                if (x < 15)
                {
                    sum = sum + x;
                }
            }
            //Вывод ответа
            textBox1.Text = sum.ToString();
        }
    }
}
