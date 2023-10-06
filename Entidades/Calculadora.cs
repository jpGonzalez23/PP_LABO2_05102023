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
        
        public List<string> Operaciones 
        { 
            get { return this.operaciones; } 
        }

        public Numeracion PrimerOperador 
        {
            get { return this.primerOperador; } 
            set
            {
                this.primerOperador = value;
            } 
        }

        public Numeracion SegundoOperador 
        { 
            get { return this.segundoOperador; } 
            set 
            { 
                this.segundoOperador = value; 
            } 
        }

        public Numeracion Resultado 
        { 
            get { return this.resultado; }
        }

        public static ESistema Sistema 
        { 
            get { return Calculadora.sistema; }
            set
            {
                Calculadora.sistema = value;
            }
        }

        static Calculadora()
        {
            Calculadora.sistema = ESistema.Decimal;
        }
        
        public Calculadora()
        {
            this.operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno):this()
        {
            this.nombreAlumno = nombreAlumno;
        }

        public void Calcular()
        {
            //this.PrimerOperador + this.SegundoOperador;
        }

        public void Calcular(char operador)
        {
            switch (operador)
            {
                case '-':
                    break;
                case '*':
                    break;
                case '/':
                    break;
                default:
                    this.Calcular();
                    break;
            }
        }

        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }

        private Numeracion MapeaResultado(double valor)
        {
            switch(sistema)
            {
                case ESistema.Binario:
                    return new SistemaBinario(valor.ToString());
                default:
                    return new SistemaDecimal(valor.ToString());
            }
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Calculadora.Sistema}");
            sb.AppendLine($"{this.PrimerOperador}");
            sb.AppendLine($"{this.SegundoOperador}");
            sb.AppendLine($"{this.Operaciones}");
        }
    }
}
