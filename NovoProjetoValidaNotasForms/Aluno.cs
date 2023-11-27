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
        public int NotaMat { get; set; }
        public int NotaHis { get; set; }
        public int NotaPor { get; set; }
        public int NotaArt { get; set; }
        public int NotaFis { get; set; }
        public int NotaIng { get; set; }
    }
    public class Media
    {
        public int MediaMat { get; set; }
        public int MediaPor { get; set; }
        public int MediaHis { get; set; }
        public int MediaArt { get; set; }
        public int MediaFis { get; set; }
        public int MediaIng { get; set; }
    }
}
