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
    public partial class ExibeBoletim : Form
    {
        private List<Aluno> lstAlunoRecebe;

        public ExibeBoletim(List<Aluno> lstAlunos)
        {
            InitializeComponent();
            this.lstAlunoRecebe = lstAlunos;
        }

        private void ExibeBoletim_Load(object sender, EventArgs e)
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
            dataGridView1.Columns.Add("Media Matéria", "Media da Materia: ");

            foreach (var aluno in lstAlunoRecebe)
            {
                foreach (var notas in aluno.notas)
                {
                    dataGridView1.Rows.Add(aluno.Nome, notas.NotaMat, notas.NotaPor, notas.NotaFis, notas.NotaHis, notas.NotaIng, notas.NotaArt);
                }
                foreach (var media in aluno.media)
                {
                    dataGridView1.Rows.Add(media.MediaMat, media.MediaMat, media.MediaFis, media.MediaHis, media.MediaIng, media.MediaArt);
                }
            }
        }
    }
}