using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework_3May_1
{
    public partial class Exercise1 : Form
    {
        string pathInput = @"E:\Алгоритмизация\Homework_3May_1\Homework_3May_1\Файл с числами.txt";
        string pathOutput = @"E:\Алгоритмизация\Homework_3May_1\Homework_3May_1\Готовый файл.txt";
        int[] numbers;

        public Exercise1()
        {
            InitializeComponent();
        }

        private void GoToExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoToTurn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GoToReadFile_Click(object sender, EventArgs e)
        {
            // считываем количество строк и даём соответствующий размер массиву (рассчитываем на файл небольших размеров (до ~0,5 ГБ)) 
            int SizeArray = File.ReadAllLines(pathInput).Length;
            numbers = new int[SizeArray];

            // считывание чисел из файла и записывание их в массив
            try
            {
                using (StreamReader sr = new StreamReader(pathInput, System.Text.Encoding.Default))
                {
                    string line;
                    for(int i = 0; (line = sr.ReadLine()) != null; i++)
                    {
                        numbers[i] = int.Parse(line);
                    }
                }
                MessageBox.Show("Из файла успешно были считаны числа", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToSortArray.Enabled = true;
                GoToFillFile.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Из файла не были считаны числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoToSortArray_Click(object sender, EventArgs e)
        {
            // сортируем массив по возрастанию, а затем "переворачиваем" его
            Array.Sort(numbers);
            Array.Reverse(numbers);
            MessageBox.Show("Числа были успешно отсортированы", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToFillFile.Enabled = true;
        }

        private void GoToFillFile_Click(object sender, EventArgs e)
        {
            // записываем в файл отсортированный массив
            try
            {
                using (StreamWriter sw = new StreamWriter(pathOutput, false, System.Text.Encoding.Default))
                {
                    foreach (var num in numbers)
                    {
                        sw.WriteLine(num);
                    }
                }
                MessageBox.Show("В файл успешно были записаны числа", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("В файл не были записаны числа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
