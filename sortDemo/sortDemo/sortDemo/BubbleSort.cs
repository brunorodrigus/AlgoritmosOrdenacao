using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortDemo
{
    class BubbleSort
    {
        private int[] myArray;
        private TimeSpan tempo;
        private double trocas;
        private double interacoes;
        private string nome;

        public TimeSpan TempoExec { get => tempo; }
        public double Trocas { get => trocas; }
        public double Interacoes { get => interacoes; }
        public string Nome { get => nome; }

        public BubbleSort(string arquivo)
        {
            string[] records = File.ReadAllLines(arquivo);
            nome = arquivo;
            myArray = Array.ConvertAll(records, new Converter<string, int>(i => int.Parse(i)));
            DateTime begin = DateTime.Now;
            Bubble(myArray, myArray.Length);
            TimeSpan dif = DateTime.Now - begin;
            tempo = dif;
        }

        void Bubble(int[] arr, int length)
        {
            interacoes = 0;
            trocas = 0;            
            int repos = 0;

            for (int i = 0; i < length; i++)
            {
                Application.DoEvents();
                for (int j = 0; j < length - 1; j++)
                {
                    Application.DoEvents();
                    interacoes++;
                    if (arr[j] > arr[j + 1])
                    {
                        repos = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = repos;
                        trocas++;
                    }
                }
            }
            
        }
    }
}
