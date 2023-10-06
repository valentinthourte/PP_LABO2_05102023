namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override double ValorNumerico => NumeracionHelper.GetNumeroDecimalFromBinario(this.valor);

        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                {
                    return this.BinarioADecimal();
                }
                case ESistema.Binario:
                default:
                    {
                        return this;

                    }
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaBinarioValido(valor);
        }

        private Numeracion BinarioADecimal()
        {
            string numeroDecimal = double.MinValue.ToString();
            if (this.valor != Numeracion.msgError)
            {
                numeroDecimal = this.ValorNumerico.ToString();
            }
            return new SistemaDecimal(numeroDecimal);
        }

        private bool EsSistemaBinarioValido(string cadena)
        {
            bool esBinario = true;
            List<string> caracteresBinarios = new List<string> { "0", "1" };
            int i = 0;
            while (esBinario && i < cadena.Length)
            {
                string caracter = cadena[i].ToString();
                if (!caracteresBinarios.Contains(caracter))
                {
                    esBinario = false;
                }
                i++;
            }
            return esBinario;
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }
    }
}