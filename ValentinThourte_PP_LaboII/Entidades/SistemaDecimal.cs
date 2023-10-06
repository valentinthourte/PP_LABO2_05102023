using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {
        internal override double ValorNumerico => double.Parse(this.valor);

        public SistemaDecimal(string valor) : base(valor) 
        { 
        }
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            Numeracion numeracionDevolver = this;

            switch (sistema)
            {

                case ESistema.Binario:
                    {
                        numeracionDevolver = this.DecimalABinario();
                        break;
                    }
                case ESistema.Decimal:
                default:
                    {
                        numeracionDevolver = this;
                        break;
                    }
            }
            return numeracionDevolver;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            return base.EsNumeracionValida(valor) && this.EsSistemaDecimalValido(valor);
        }

        private SistemaBinario DecimalABinario()
        {
            string valorBinario = Numeracion.msgError;
            if (this.ValorNumerico > 0)
            {
                valorBinario = NumeracionHelper.GetNumeroBinarioFromDecimal(this.ValorNumerico);
            }
            return new SistemaBinario(valorBinario);
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out var result);
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }
        public static implicit operator SistemaDecimal(double valor)
        {
            return valor.ToString();
        }

    }
}
