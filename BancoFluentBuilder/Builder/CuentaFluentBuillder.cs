using System.Collections.Generic;
using BancoFluentBuilder.Models;

namespace BancoFluentBuilder.Builder
{
    public class CuentaFluentBuillder
    {
        private readonly Cuenta _cuenta;

        private CuentaFluentBuillder(int nocuenta)
        {
            _cuenta = new Cuenta { Nocuenta = nocuenta };
        }

        public static CuentaFluentBuillder Crear(int nocuenta)
        {
            return new CuentaFluentBuillder(nocuenta);
        }

        public CuentaFluentBuillder EstablecerTipoCuenta(string tipo)
        {
            if(tipo == "Basic")
                _cuenta.Tipo = TipoEnum.Basic;
            else if(tipo == "Black")
                _cuenta.Tipo = TipoEnum.Black;
            else if (tipo == "Golden")
                _cuenta.Tipo = TipoEnum.Golden;
            else _cuenta.Tipo = TipoEnum.Platinum;

            return this;
        }

        public CuentaFluentBuillder EstablecerNombre(string nombre)
        {
            _cuenta.Nombre = nombre;
            return this;
        }

        public CuentaFluentBuillder EstablecerSaldo(double saldo)
        {
            _cuenta.Saldo = saldo;
            return this;
        }
        public CuentaFluentBuillder EstablecerTasa(double tasa)
        {
            _cuenta.Tasa = tasa;
            return this;
        }

        public Cuenta Realizar()
        {
            return _cuenta;
        }
    }
}
