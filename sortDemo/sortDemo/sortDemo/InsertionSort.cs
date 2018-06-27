using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortDemo
{
    class InsertionSort
    {
        private int[] myArray;
        private TimeSpan tempo;
        private long trocas;
        private long interacoes;
        private string nome;

        public TimeSpan TempoExec { get => tempo; }
        public long Trocas { get => trocas; }
        public long Interacoes { get => interacoes; }
        public string Nome { get => nome; }

        public InsertionSort(string arquivo)
        {
            string[] records = File.ReadAllLines(arquivo);
            nome = arquivo;
            myArray = Array.ConvertAll(records, new Converter<string, int>(i => int.Parse(i)));
            DateTime begin = DateTime.Now;
            Insertion(myArray);
            TimeSpan dif = DateTime.Now - begin;
            tempo = dif;

        }
        void Insertion(int[] intArray)
        {
            interacoes = 0;
            trocas = 0;
            int temp, j;
            for (int i = 1; i < intArray.Length; i++)
            {
                interacoes++;
                Application.DoEvents();
                temp = intArray[i];
                j = i - 1;

                while (j >= 0 && intArray[j] > temp)
                {
                    trocas++;
                    intArray[j + 1] = intArray[j];
                    j--;
                }
                interacoes++;
                intArray[j + 1] = temp;
            }
        }
        
    }
}
