using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sortDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                if(tabControl1.SelectedTab == tabPage1)
                {
                    BubbleResultado.Text = "Executando";
                    ((Control)this.button1).Enabled = false;
                    BubbleSort bs = new BubbleSort(fd.FileName);
                    ((Control)this.button1).Enabled = true;
                    BubbleResultado.Text = "Tempo:\n" + bs.TempoExec.Minutes.ToString() + "  Minutos\n" + bs.TempoExec.Seconds.ToString() + "  Segundos\n" + bs.TempoExec.Milliseconds.ToString() + "  Milisegundos\nNumero de trocas  : " + bs.Trocas.ToString() + "\nNumero de interacoes  : " + bs.Interacoes.ToString() + "\nNome do aquivo :\n" + bs.Nome.ToString();
                }
                if (tabControl1.SelectedTab == tabPage2)
                {
                    QuickResultado.Text = "Executando";
                    ((Control)this.button1).Enabled = false;
                    QuickSort qs = new QuickSort(fd.FileName);
                    ((Control)this.button1).Enabled = true;
                    QuickResultado.Text = "Tempo:\n" + qs.TempoExec.Minutes.ToString() + "  Minutos\n" + qs.TempoExec.Seconds.ToString() + "  Segundos\n" + qs.TempoExec.Milliseconds.ToString() + "  Milisegundos\nNumero de trocas  : " + qs.Trocas.ToString() + "\nNumero de interacoes  : " + qs.Interacoes.ToString() + "\nNome do aquivo :\n" + qs.Nome.ToString();

                }
                if (tabControl1.SelectedTab == tabPage3)
                {
                    SelectionResultado.Text = "Executando";
                    ((Control)this.button1).Enabled = false;
                    SelectionSort ss = new SelectionSort(fd.FileName);
                    ((Control)this.button1).Enabled = true;
                    SelectionResultado.Text = "Tempo:\n" + ss.TempoExec.Minutes.ToString() + "  Minutos\n" + ss.TempoExec.Seconds.ToString() + "  Segundos\n" + ss.TempoExec.Milliseconds.ToString() + "  Milisegundos\nNumero de trocas  : " + ss.Trocas.ToString() + "\nNumero de interacoes  : " + ss.Interacoes.ToString() + "\nNome do aquivo :\n" + ss.Nome.ToString();

                }
                if (tabControl1.SelectedTab == tabPage4)
                {
                    BucketResultado.Text = "Executando";
                    ((Control)this.button1).Enabled = false;
                    BucketSort bk = new BucketSort(fd.FileName);
                    ((Control)this.button1).Enabled = true;
                    BucketResultado.Text = "Tempo:\n" + bk.TempoExec.Minutes.ToString() + "  Minutos\n" + bk.TempoExec.Seconds.ToString() + "  Segundos\n" + bk.TempoExec.Milliseconds.ToString() + "  Milisegundos\nNumero de trocas  : " + bk.Trocas.ToString() + "\nNumero de interacoes  : " + bk.Interacoes.ToString() + "\nNome do aquivo :\n" + bk.Nome.ToString();

                }
                if (tabControl1.SelectedTab == tabPage5)
                {
                    InsertionResultado.Text = "Executando";
                    ((Control)this.button1).Enabled = false;
                    InsertionSort iis = new InsertionSort(fd.FileName);
                    ((Control)this.button1).Enabled = true;
                    InsertionResultado.Text = "Tempo:\n" + iis.TempoExec.Minutes.ToString() + "  Minutos\n" + iis.TempoExec.Seconds.ToString() + "  Segundos\n" + iis.TempoExec.Milliseconds.ToString() + "  Milisegundos\nNumero de trocas  : " + iis.Trocas.ToString() + "\nNumero de interacoes  : " + iis.Interacoes.ToString() + "\nNome do aquivo :\n" + iis.Nome.ToString();

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
