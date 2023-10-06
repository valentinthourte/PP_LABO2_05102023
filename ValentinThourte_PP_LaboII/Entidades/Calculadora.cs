using System.Security.Cryptography;
using System.Text;

namespace Entidades
{
    public class Calculadora
    {
        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion resultado;
        private Numeracion segundoOperando;
        private static ESistema sistema;

        public string NombreAlumno { get => nombreAlumno; set => nombreAlumno = value; }
        public List<string> Operaciones { get => operaciones; }
        public Numeracion PrimerOperando { get => primerOperando; set => primerOperando = value; }
        public Numeracion SegundoOperando { get => segundoOperando; set => segundoOperando = value; }
        public Numeracion Resultado { get => resultado; }
        public static ESistema Sistema { get => sistema; set => sistema = value; }

        static Calculadora()
        {
            Calculadora.Sistema = ESistema.Decimal;
        }
        public Calculadora()
        {
            this.operaciones = new List<string>(); 
        }
        public Calculadora(string nombreAlumno) : this()
        {
            this.NombreAlumno = nombreAlumno;
        }

        public void Calcular()
        {
            Calcular('+');
        }
        public void Calcular(char operador)
        {
            double valorNumericoResultado = double.MinValue;
            if (PuedoCalcular())
            {
                switch(operador)
                {
                    case '-':
                        {
                            valorNumericoResultado = PrimerOperando - SegundoOperando;
                            break;
                        }
                    case '*':
                        {
                            valorNumericoResultado = PrimerOperando * SegundoOperando;
                            break;
                        }
                    case '/':
                        {
                            valorNumericoResultado = PrimerOperando / SegundoOperando;
                            break;
                        }
                    case '+':
                    default:
                        {
                            valorNumericoResultado = PrimerOperando + SegundoOperando;
                            break;
                        }
                }
                this.resultado = MapeaResultado(valorNumericoResultado);
            }
            else
            {
                throw new Exception("No se puede operar: Los operandos son de distinto tipo o contienen valores inválidos.");
            }
        }

        private bool PuedoCalcular()
        {
            // Extraigo la lógica de si puedo calcular a una funcion, y agrego validación por si alguno de los operandos tiene número inválido
            return this.PrimerOperando is not null && this.SegundoOperando is not null
                && this.PrimerOperando == this.SegundoOperando && !this.PrimerOperando.EsError() && !this.SegundoOperando.EsError();
        }

        private Numeracion MapeaResultado(double valorNumericoResultado)
        {
            Numeracion resultado;
            switch(Calculadora.Sistema)
            {
                case ESistema.Binario:
                    {
                        resultado = new SistemaDecimal(NumeracionHelper.GetNumeroBinarioFromDecimal(valorNumericoResultado));
                        break;
                    }
                case ESistema.Decimal:
                default:
                    {
                        resultado = new SistemaDecimal(valorNumericoResultado.ToString());
                        break;
                    }

            }
            return resultado;
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.PrimerOperando.Valor} ");
            sb.AppendLine($"{operador} ");
            sb.AppendLine($"{this.SegundoOperando.Valor} ");
            sb.AppendLine($"({Calculadora.Sistema}) ");
            sb.AppendLine($"=> {this.Resultado.Valor}");
            this.operaciones.Add(sb.ToString());
        }
        
        public void EliminarHistorialDeOperaciones()
        {
            this.operaciones.Clear();
        }
    }
}
