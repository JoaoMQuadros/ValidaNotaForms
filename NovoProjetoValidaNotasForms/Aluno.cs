using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoProjetoValidaNotasForms
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<Notas> notas = new List<Notas>();
        public List<Media> media = new List<Media>();
    }
    public class Notas
    {
        public double NotaMat { get; set; }
        public double NotaHis { get; set; }
        public double NotaPor { get; set; }
        public double NotaArt { get; set; }
        public double NotaFis { get; set; }
        public double NotaIng { get; set; }
    }
    public class Media
    {
        public double MediaMat { get; set; }
        public double MediaPor { get; set; }
        public double MediaHis { get; set; }
        public double MediaArt { get; set; }
        public double MediaFis { get; set; }
        public double MediaIng { get; set; }
    }
}
