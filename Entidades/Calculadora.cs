using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        
        private List<string> operaciones;
        
        private Numeracion primerOperador;
        private Numeracion segundoOperador;
        private Numeracion resultado;
        
        private static ESistema sistema;

        /// <summary>
        /// Constructor statatico
        /// </summary>
        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }

        /// <summary>
        /// Constructor sin parametro, inicializa la lista
        /// </summary>
        public Calculadora()
        {
            this.operaciones = new List<string>();
        }

        /// <summary>
        /// Constructor que resibe el nombre del alumno
        /// </summary>
        /// <param name="nombreAlumno">Recibe como parametro el nombre del alumno</param>
        public Calculadora(string nombreAlumno) : this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        /// <summary>
        /// Propieda de lectura y escritura del atribuno nombreAlumno
        /// </summary>
        public string NombreAlumno 
        { 
            get { return this.nombreAlumno; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.nombreAlumno = value;
                }
            } 
        }
        
        /// <summary>
        /// 
        /// </summary>
        public List<string> Operaciones 
        { 
            get { return this.operaciones; } 
        }

        /// <summary>
        /// 
        /// </summary>
        public Numeracion PrimerOperador 
        {
            get { return this.primerOperador; } 
            set
            {
                this.primerOperador = value;
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        public Numeracion SegundoOperador 
        { 
            get { return this.segundoOperador; } 
            set 
            { 
                this.segundoOperador = value; 
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        public Numeracion Resultado 
        { 
            get { return this.resultado; }
        }

        /// <summary>
        /// 
        /// </summary>
        public static ESistema Sistema 
        { 
            get { return Calculadora.sistema; }
            set
            {
                Calculadora.sistema = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Calcular()
        {
            //this.PrimerOperador + this.SegundoOperador;
            this.Calcular('+');
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operador"></param>
        public void Calcular(char operador)
        {
            double resultado = double.MinValue;

            if (this.primerOperador == this.segundoOperador)
            {
                switch (operador)
                {
                    case '-':
                        resultado = this.primerOperador.ValorNumerico - this.segundoOperador.ValorNumerico;
                        break;
                    
                    case '*':
                        resultado = this.primerOperador.ValorNumerico * this.segundoOperador.ValorNumerico;
                        break;
                    
                    case '/':
                        resultado = this.primerOperador.ValorNumerico / this.segundoOperador.ValorNumerico;
                        break;
                    
                    default:
                        resultado = this.primerOperador.ValorNumerico + this.segundoOperador.ValorNumerico;
                        break;
                }
            }

            this.resultado = this.MapeaResultado(resultado);
        }

        /// <summary>
        /// 
        /// </summary>
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private Numeracion MapeaResultado(double valor)
        {
            //switch(sistema)
            //{
            //    case ESistema.Binario:
            //        return new SistemaBinario(valor.ToString());
            //    default:
            //        return new SistemaDecimal(valor.ToString());
            //}

            Numeracion resultado = (SistemaDecimal)valor.ToString();

            return resultado.CambiarSistemaDeNumeracion(Calculadora.sistema);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operador"></param>
        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();

            //sb.AppendLine($"{Calculadora.Sistema}");
            //sb.AppendLine($"{this.PrimerOperador}");
            //sb.AppendLine($"{this.SegundoOperador}");
            //sb.AppendLine($"{this.Operaciones}");

            sb.AppendLine($"[{Calculadora.Sistema}] => {this.primerOperador.Valor} {operador} {this.segundoOperador.Valor} = {this.resultado.Valor}");

            this.operaciones.Add(sb.ToString());
        }
    }
}
