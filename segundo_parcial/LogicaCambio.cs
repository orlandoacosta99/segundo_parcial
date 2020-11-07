using System;
using System.Collections.Generic;
using System.Text;

namespace segundo_parcial
{
    class LogicaCambio
    {
        //Encapsular los datos
        private double numero1;
        private double numero2;
        private double resultado;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public double Conversion(double num1, double num2, string op)
        {
            double resultado = double.NaN;
            System.Console.WriteLine("Primer valor de la operación: {0}", num1);
            System.Console.WriteLine("segundo valor de la operación: {0}", num2);
            return resultado;
        }
    }
}
