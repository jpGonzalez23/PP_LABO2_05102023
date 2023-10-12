using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        public SistemaDecimal(string valor) : base(valor) { }

        internal override double ValorNumerico
        {
            get
            {
                return (double) this;
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            //if (sistema == ESistema.Decimal)
            //{
            //    return this;
            //}

            //return new SistemaDecimal(this.ValorNumerico.ToString());

            switch(sistema)
            {
                case ESistema.Binario:
                    return this.DecimalABinario();
            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            //if (base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor))
            //{
            //    return true;
            //}
            //return false;

            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);
        }

        private bool EsSistemaDecimalValido(string valor) 
        {
            //if (double.TryParse(valor, out double auxValor))
            //{
            //    return true;
            //}
            //return false;

            return double.TryParse(valor, out double resultado);
        }

        private SistemaBinario DecimalABinario()
        {
            //if (this.ValorNumerico > 0)
            //{
            //    do
            //    {
            //        string valorBinario = string.Empty;

            //        do
            //        {
            //            valorBinario = ((int)this.ValorNumerico % 2) + valorBinario;

            //        } while (this.ValorNumerico >= 2);
            //        valorBinario = valor + valorBinario;

            //        return valorBinario;

            //    } while (true);
            //}
            //else
            //{
            //    return new SistemaBinario(Numeracion.msgError);
            //}

            int valor = (int)this.ValorNumerico;

            if (valor > 0)
            {
                string binario = string.Empty;

                while(valor > 0)
                {
                    int resto = valor % 2;
                    valor /= 2;

                    binario = resto + binario;
                }
                return binario;
            }

            return Numeracion.msgError;
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
    }
}
