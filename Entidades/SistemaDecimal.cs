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
                return double.Parse(base.Valor);
            }
        }

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return this;
            }

            return new SistemaDecimal(this.ValorNumerico.ToString());
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }

        private bool EsSistemaDecimalValido(string valor) 
        {
            if (double.TryParse(valor, out double auxValor))
            {
                return true;
            }
            return false;
        }

        private SistemaBinario DecimalABinario()
        {
            if (this.ValorNumerico > 0)
            {
                do
                {
                    string auxBinaro = this.ValorNumerico.ToString();

                } while (true);
            }
            else
            {
                return new SistemaBinario(Numeracion.msgError);
            }
        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal((string)valor);
        }
    }
}
