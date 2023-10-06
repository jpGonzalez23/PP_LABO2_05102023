namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string? msgError;
        protected string? valor;

        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.InicializarValores(valor);
        }

        public string Valor
        {
            get
            {
                return this.valor;
            }
        }

        internal abstract double ValorNumerico { get; }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return true;
            }
            return false;
        }

        private void InicializarValores(string valor)
        {
            if (this.EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = Numeracion.msgError;
            }
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return double.Parse(numeracion.Valor);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is not null || n2 is not null)
            {
                return false;
            }
            return n1.Valor == n2.Valor && n1.GetType() == n2.GetType();
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        /// <summary>
        /// Metodo para sumar dos numeros del tipo numeracion
        /// </summary>
        /// <param name="n1">Ingreso de un numero tipo numeracion</param>
        /// <param name="n2">Ingreso de un numero tipo numeracion</param>
        /// <returns></returns>
        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double suma = n1.ValorNumerico + n2.ValorNumerico;
            return 
        }

        /// <summary>
        /// Metodo para restar dos numeros del tipo numeracion
        /// </summary>
        /// <param name="n1">Ingreso de un numero tipo numeracion</param>
        /// <param name="n2">Ingreso de un numero tipo numeracionparam>
        /// <returns></returns>
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resta = n1.ValorNumerico - n2.ValorNumerico;
            return n1.CambiarSistemaDeNumeracion(ESistema.Decimal);
        }

        /// <summary>
        /// Metodo para multiplicar dos numeros del tipo numeracion
        /// </summary>
        /// <param name="n1">Ingreso de un numero tipo numeracion</param>
        /// <param name="n2">Ingreso de un numero tipo numeracion</param>
        /// <returns></returns>
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            
        }

        /// <summary>
        /// Metodo para divir dos numeros del tipo numeracion
        /// </summary>
        /// <param name="n1">Ingreso de un numero tipo numeracion</param>
        /// <param name="n2">Ingreso de un numero tipo numeracion</param>
        /// <returns></returns>
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            
        }
    }
}