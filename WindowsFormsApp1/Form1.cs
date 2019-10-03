using BancoFluentBuilder.Models;
using BancoFluentBuilder.Builder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Cuenta> lista = new List<Cuenta>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Cuenta>);
            dataGridView1.DataSource = lista;
            comboBox1.DataSource = Enum.GetValues(typeof(TipoEnum));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(nocuentatb.Text))
            {
                MessageBox.Show("Numero de cuenta invalido");
                nocuentatb.Text = "";
                return;
            }
                
            if (IsNumeric(propietariotb.Text))
            {
                MessageBox.Show("Nombre Propietario Invalido");
                propietariotb.Text = "";
                return;
            }
            if (!IsNumeric(tasatb.Text))
            {
                MessageBox.Show("Tasa Invalida");
                tasatb.Text = "";
                return;
            }
            if (!IsNumeric(saldotb.Text))
            {
                MessageBox.Show("Saldo Invalido");
                saldotb.Text = "";
                return;
            }
            double t = Convert.ToDouble(tasatb.Text);
            if (t < 1)
                t = t * 100;
            Cuenta cuentapersonalizada = CuentaFluentBuillder.Crear(Convert.ToInt32(nocuentatb.Text))
                .EstablecerNombre(propietariotb.Text)
                .EstablecerSaldo(Convert.ToDouble(saldotb.Text))
                .EstablecerTipoCuenta(comboBox1.Text)
                .EstablecerTasa(t)
                .Realizar();
            lista.Add(cuentapersonalizada);
            dataGridView1.DataSource = new BindingSource(lista, null);
            dataGridView1.DataSource = typeof(List<Cuenta>);
            dataGridView1.DataSource = lista;
        }

        public bool IsNumeric(string a)
        {
            foreach (char c in a)
            {
                if(c != 46)
                    if (!Char.IsNumber(c))
                        return false;
            }
            return true;
        }
    }
}
