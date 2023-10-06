using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor) { }

        internal override double ValorNumerico
        {
            get
            {
                return double.Parse(base.Valor);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return this;
            }

            return new SistemaBinario(this.ValorNumerico.ToString());
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor) ? true : false;
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char c in valor)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }

            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            if (this.ValorNumerico.ToString() != Numeracion.msgError)
            {
                double resultado = 0;
                int longitud = base.Valor.Length;

                for (int i = 0; i < longitud - 1; i++)
                {
                    if (base.Valor[i] == '1')
                    {
                        int exponente = longitud - i - 1;
                        resultado = Math.Pow(2, exponente);
                    }
                }
                return new SistemaDecimal(resultado.ToString());
            }
            else
            {
                return new SistemaDecimal(double.MinValue.ToString());
            }
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}
