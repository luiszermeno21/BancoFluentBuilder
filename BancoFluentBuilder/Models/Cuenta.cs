using System.Collections.Generic;

namespace BancoFluentBuilder.Models
{
    public class Cuenta
    {
        public int Nocuenta { get; set; }
        public string Nombre { get; set; }
        public double Saldo { get; set; }
        public double Tasa { get; set; }
        public TipoEnum Tipo { get; set; }

        public Cuenta()
        {

        }

        public Cuenta(int nocuenta, double saldo, string nombre, double tasa, TipoEnum tipo)
        {
            Nocuenta = nocuenta;
            Saldo = saldo;
            Nombre = nombre;
            Tasa = tasa;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"No. Cuenta: {Nocuenta} / Tipo de Cuenta: {Tipo} / Nombre del Propietario: {Nombre} / Saldo: {Saldo} / Tasa: {Tasa}";
        }
    }
}
