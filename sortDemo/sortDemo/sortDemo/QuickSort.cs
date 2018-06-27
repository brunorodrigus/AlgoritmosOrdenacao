using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortDemo
{
    class QuickSort
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

        public QuickSort(string arquivo)
        {
            string[] records = File.ReadAllLines(arquivo);
            nome = arquivo;
            myArray = Array.ConvertAll(records, new Converter<string, int>(i => int.Parse(i)));
            DateTime begin = DateTime.Now;
            int inicio = 0;
            int fim = myArray.Length - 1;
            Quick(myArray, inicio, fim);
            TimeSpan dif = DateTime.Now - begin;
            tempo = dif;

        }
        
        void Quick(int[] arr, int inicio, int fim)
        {
            int i = inicio, f = fim;
            int auxiliar;
            int pivot = arr[(inicio + fim) / 2];

            
            while (i <= f)
            {
                interacoes++;
                Application.DoEvents();
                while (arr[i] < pivot)
                {
                    interacoes++;
                    i++;
                }
                while (arr[f] > pivot)
                {
                    interacoes++;
                    f--;
                }
                if (i <= f)
                {
                    Application.DoEvents();
                    auxiliar = arr[i];
                    arr[i] = arr[f];
                    arr[f] = auxiliar;
                    i++;
                    f--;
                    trocas++;                    
                }
            }         
            
            if (inicio < f)
            {
                Quick(arr, inicio, f);
            }
            if (i < fim)
            {
                Quick(arr, i, fim);
            }
                
        }
    }
}




