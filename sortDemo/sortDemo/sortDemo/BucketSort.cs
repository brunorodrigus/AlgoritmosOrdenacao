using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sortDemo
{
    class BucketSort
    {
        private int[] myArray;
        private TimeSpan tempo;
        private int interacoes;
        private int trocas;
        private string nome;

        public TimeSpan TempoExec { get => tempo; }
        public int Interacoes { get => interacoes; }
        public int Trocas { get => trocas; }
        public string Nome { get => nome; }

        public BucketSort(string arquivo)
        {
            string[] records = File.ReadAllLines(arquivo);
            nome = arquivo;
            myArray = Array.ConvertAll(records, new Converter<string, int>(i => int.Parse(i)));
            DateTime begin = DateTime.Now;
            bucket_sort(myArray);
            TimeSpan dif = DateTime.Now - begin;
            tempo = dif;
        }
        void bucket_sort(int[] data)
        {
            int minValue = data[0];
            int maxValue = data[0];
            trocas = 0;
            interacoes = 0;
            for (int i = 1; i < data.Length; i++)
            {
                Application.DoEvents();
                if (data[i] > maxValue)
                {
                    interacoes++;
                    maxValue = data[i];
                }
                if (data[i] < minValue)
                {
                    interacoes++;
                    minValue = data[i];
                }
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                Application.DoEvents();
                bucket[i] = new List<int>();
                interacoes++;
            }

            for (int i = 0; i < data.Length; i++)
            {
                Application.DoEvents();
                bucket[data[i] - minValue].Add(data[i]);
                interacoes++;
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                interacoes++;
                Application.DoEvents();
                if (bucket[i].Count > 0)
                {
                    interacoes++;
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        Application.DoEvents();
                        data[k] = bucket[i][j];
                        k++;
                        trocas++;
                    }
                }
            }

        }





    }
}