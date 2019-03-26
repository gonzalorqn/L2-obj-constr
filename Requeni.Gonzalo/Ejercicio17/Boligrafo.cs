using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta < 0)
            {
                this.tinta = 0;
            }
            else if(this.tinta > cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno = false;
            dibujo = "";
            for(int i=0;i<gasto;i++)
            {
                if(this.tinta > 0)
                {
                    dibujo += "*";
                }
            }
            if (gasto <= this.tinta)
                retorno = true;

            this.SetTinta((short)-gasto);
            
            return retorno;
        }
    }
}
