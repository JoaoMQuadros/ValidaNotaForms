using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Validador
{
    public int validaNotas(string entrada)
    {
        int comparador = 0;
        if (int.TryParse(entrada, out comparador) && comparador >= 0 && comparador <= 10)
        {
            //Entrada validada
        }
        else
        {
            MessageBox.Show("Por favor digite apenas números entre 0  a 10");
        }
            return comparador;
    }
}