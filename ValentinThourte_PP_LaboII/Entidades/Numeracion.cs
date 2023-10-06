namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        public string Valor { get => valor; }
        internal abstract double ValorNumerico { get; }

        static Numeracion()
        {
            Numeracion.msgError = "Numero Invalido";
        }
        public Numeracion()
        {

        }

        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        private void InicializaValor(string valor)
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

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);
        protected virtual bool EsNumeracionValida(string valor)
        {
            return (!(string.IsNullOrEmpty(valor?.Trim())));
        }

        public static bool operator ==(Numeracion numero1, Numeracion numero2) => numero1.GetType() == numero2.GetType();
        public static bool operator !=(Numeracion numero1, Numeracion numero2) => !(numero1 == numero2);

        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }
        public bool EsError()
        {
            return this.valor == Numeracion.msgError;
        }

        public static double operator +(Numeracion numero1, Numeracion numero2)
        {
            var valor = double.MinValue;
            if (numero1 is not null && numero2 is not null && numero1 == numero2)
            {
                valor = numero1.ValorNumerico + numero2.ValorNumerico;
            }
            return valor;
        }
        public static double operator -(Numeracion numero1, Numeracion numero2)
        {
            var valor = double.MinValue;
            if (numero1 is not null && numero2 is not null && numero1 == numero2)
            {
                valor =numero1.ValorNumerico - numero2.ValorNumerico;
            }
            return valor;
        }
        public static double operator *(Numeracion numero1, Numeracion numero2)
        {
            var valor = double.MinValue;
            if (numero1 is not null && numero2 is not null && numero1 == numero2)
            {
                valor = numero1.ValorNumerico * numero2.ValorNumerico;

            }
            return valor;
        }
        public static double operator /(Numeracion numero1, Numeracion numero2)
        {
            var valor = double.MinValue;
            if (numero1 == numero2 && numero2.ValorNumerico != 0)
            {
                valor = numero1.ValorNumerico / numero2.ValorNumerico;

            }
            return valor;
        }
    }
}