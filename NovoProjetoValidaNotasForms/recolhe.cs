using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovoProjetoValidaNotasForms
{
    public partial class frm_validaNot : Form
    {
        Validador validor = new Validador();
        //List Alunos
        List<Aluno> lstAluno = new List<Aluno>();
        //Valores dos divisores: 
        int numAluno = 0;
        int numMedia = 0;        

        public frm_validaNot()
        {
            InitializeComponent();
            for (int i = 0; i < numAluno; i++)
            {
                txt_nomeAluno.Focus();

                for (int j = 0; j < numMedia; j++)
                {
                    txt_notaMat.Focus();
                }
            }

        }

        private void bnt_confirmaMedia_Click(object sender, EventArgs e)
        {
            numAluno = Convert.ToInt32(txt_numAluno.Text);
            numMedia = Convert.ToInt32(txt_numMedia.Text);
            MessageBox.Show("Valores foram regitrados !");
            txt_nomeAluno.Focus();

        }

        private void btn_confirmaNome_Click(object sender, EventArgs e)
        {
            Aluno novoAluno = new Aluno();
            novoAluno.Nome = txt_nomeAluno.Text;
            lstAluno.Add(novoAluno);
            MessageBox.Show("Nome do Aluno registrado com sucesso");
            txt_notaMat.Focus();
        }

        private void bnt_confirmaNota_Click(object sender, EventArgs e)
        {
          if(numMedia > 0)
            {
                Notas rcbNotas = new Notas();
                rcbNotas.NotaMat = validor.validaNotas(txt_notaMat.Text);
                rcbNotas.NotaPor = validor.validaNotas(txt_notaPor.Text);
                rcbNotas.NotaFis = validor.validaNotas(txt_notaFis.Text);
                rcbNotas.NotaHis = validor.validaNotas(txt_notaHis.Text);
                rcbNotas.NotaArt = validor.validaNotas(txt_notaArt.Text);
                rcbNotas.NotaIng = validor.validaNotas(txt_notaIng.Text);
                lstAluno[lstAluno.Count - 1].notas.Add(rcbNotas);             
                txt_notaMat.Focus();
                limpaConsole();
            }
           
        }

        private void btn_mostraResul_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("NomeAluno", "Aluno:");
            dataGridView1.Columns.Add("NotaMat", "Matemárica :");
            dataGridView1.Columns.Add("NotaPor", "Português :");
            dataGridView1.Columns.Add("NotaFis", "Fisícia :");
            dataGridView1.Columns.Add("NotaHis", "História :");
            dataGridView1.Columns.Add("NotaIng", "Inglês:");
            dataGridView1.Columns.Add("NotaArt", "Artês :");
            foreach (var aluno in lstAluno)
            {
                foreach (var notas in aluno.notas)
                {
                    dataGridView1.Rows.Add(aluno.Nome, notas.NotaMat, notas.NotaPor, notas.NotaFis, notas.NotaHis, notas.NotaIng, notas.NotaArt);
                }
            }
        }

        private void btn_boletim_Click(object sender, EventArgs e)
        {
            somaMedia();
            ExibeBoletim boletim = new ExibeBoletim(lstAluno);
            boletim.ShowDialog();

        }
        private void limpaConsole()
        {
            txt_nomeAluno.Clear();
            txt_notaMat.Clear();
            txt_notaPor.Clear();
            txt_notaIng.Clear();
            txt_notaHis.Clear();
            txt_notaFis.Clear();
            txt_notaArt.Clear();
        }
        private void somaMedia()
        {          
            foreach (var aluno in lstAluno)
            {
                Media media = new Media();
                double somaMat = 0;
                double somaPor = 0;
                double somaFis = 0;
                double somaHis = 0;
                double somaArt = 0;
                double somaIng = 0;

                foreach (var notas in aluno.notas)
                {
                    somaMat += notas.NotaMat;
                    somaPor += notas.NotaPor;
                    somaHis += notas.NotaHis;
                    somaFis += notas.NotaFis;
                    somaArt += notas.NotaArt;
                    somaIng += notas.NotaIng;
                }
                media.MediaMat = Convert.ToDouble(somaMat / aluno.notas.Count);
                media.MediaPor = Convert.ToDouble(somaPor / aluno.notas.Count);
                media.MediaFis = Convert.ToDouble(somaFis / aluno.notas.Count);
                media.MediaHis = Convert.ToDouble(somaHis / aluno.notas.Count);
                media.MediaArt = Convert.ToDouble(somaArt / aluno.notas.Count);
                media.MediaIng = Convert.ToDouble(somaIng / aluno.notas.Count);

                aluno.media.Add(media);
            }
        }
    }
}
