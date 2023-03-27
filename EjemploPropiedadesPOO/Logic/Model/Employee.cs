using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic.Model
{
    public class Employee:person
    {
        private string tipoContrato;
        private int sueldo;
        private int nuevoSueldo;

        public string TipoContrato { get => tipoContrato; set => tipoContrato = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public int NuevoSueldo { get => nuevoSueldo; set => nuevoSueldo = value; }

        public Employee(string nombre,string apellido,string documento,string tipoContrato, int sueldo)
            :base(nombre,apellido,documento)
        {
            this.tipoContrato = tipoContrato;
            this.sueldo = sueldo;
        }

        public string bonoEmpleado()
        {
            string mensaje ; //variable local
            if (sueldo<= 1300000)
            {
                nuevoSueldo = sueldo + 200000;
                mensaje = "Señor(a) " + Nombre + " usted tiene derecho al bono, su sueldo es: " + nuevoSueldo;
            }
            else
            {
                mensaje = "Señor(a) " + Nombre + " usted no tiene derecho al bono, su sueldo es: " + sueldo;
            }
            return mensaje;
        }
    }
}