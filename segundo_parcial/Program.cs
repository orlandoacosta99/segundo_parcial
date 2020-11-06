using System;

namespace segundo_parcial
{
    class Program
    {
        private static LogicaCambio logica_Cambio;

        public LogicaCambio LogicaCambio
        {
            get => default(LogicaCambio);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            Program miAplicacion = new Program();
            miAplicacion.ejecutarOperacionesCalculadora();
        }
        //Manejo de la pantalla
        public void prepararPantalla()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
        }
        //Negocio pero en la capa de presentación (entrada, validación y llamado al servicio)
        public void ejecutarOperacionesCalculadora()
        {   
            // datos de entrada 
            // valor convercion 
            string numInput1 = "";
            // tasa 
            string numInput2 = "";
            // resultado
            double resultado = 0;
            logica_Cambio = new LogicaCambio();
            // logica de menu op 
            string op = "";
            string op2 = "";

            prepararPantalla();

            Console.WriteLine("Bienvenido a la aplicacion de conversion \r");
            // ingreso valor convercion 
            Console.Write("\n Ingrese el valor de la moneda presione enter: ");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("No es una entrada válida.  Por favor ingrese un valor numérico: ");
                numInput1 = Console.ReadLine();
            }
            
            // menu de conversion
            
            do
            {
                Console.WriteLine("\t1 - Dolares Americanos");
                Console.WriteLine("\t2 - Euros");
                Console.WriteLine("\t3 - Yuanes (Renminbi)");
                Console.WriteLine("\t4 - Yenes (Japon)");
                Console.WriteLine("\t5 - Pesos Colombianos");             
                Console.Write("Seleccione el tipo de moneda: ");
                op = Console.ReadLine();
            } while (!op.Equals("1") && !op.Equals("2") && !op.Equals("3") && !op.Equals("4") && !op.Equals("5"));
            
            // menu tipo de valor a convertir 

            do
            {
                Console.WriteLine("\t Seleccione el tipo de valor a convertir");
                Console.WriteLine("\t1 - Dolares Americanos");
                Console.WriteLine("\t2 - Euros");
                Console.WriteLine("\t3 - Yuanes (Renminbi)");
                Console.WriteLine("\t4 - Yenes (Japon)");
                Console.WriteLine("\t5 - Pesos Colombianos");
                Console.Write("Seleccione el tipo de moneda: ");
                op2 = Console.ReadLine();
            } while (!op2.Equals("1") && !op2.Equals("2") && !op2.Equals("3") && !op2.Equals("4") && !op2.Equals("5"));
            // ingreso de tasa de cambio 
            Console.Write("\n Ingrese el valor de la tasa de cambio y presione enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("No es una entrada válida.  Por favor ingrese un valor numérico: ");
                numInput2 = Console.ReadLine();
            }



        }
    }
}
