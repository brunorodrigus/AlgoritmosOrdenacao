using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortDemo
{
    class SelectionSort
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

        public SelectionSort(string arquivo)
        {
            string[] records = File.ReadAllLines(arquivo);
            nome = arquivo;
            myArray = Array.ConvertAll(records, new Converter<string, int>(i => int.Parse(i)));
            DateTime begin = DateTime.Now;
            Select(myArray);
            TimeSpan dif = DateTime.Now - begin;
            tempo = dif;
        }
        void Select(int[] arr)
        {
            trocas = 0;
            interacoes = 0;
            int pos_min, temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                pos_min = i;

                Application.DoEvents();

                for (int j = i + 1; j < arr.Length; j++)
                {
                    interacoes++;
                    if (arr[j] < arr[pos_min])
                    {
                        interacoes++;
                        pos_min = j;
                    }
                }

                if (pos_min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[pos_min];
                    arr[pos_min] = temp;
                    trocas++;
                }
            }
        }
    }
}
