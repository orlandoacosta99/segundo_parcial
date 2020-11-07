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
            Program logica_Cambio = new Program();
            logica_Cambio.ejecutarOperacionesCalculadora();
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

            MenuConversion(); 

           // tasa de cambio
            Console.Write("\n Ingrese el valor de la tasa de cambio y presione enter: ");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.Write("No es una entrada válida.  Por favor ingrese un valor numérico: ");
                numInput2 = Console.ReadLine();
            }

            cardinalidad();

        }
        public void cardinalidad()
        {
                string op = "";
                int menu = 0;
                Console.WriteLine("Direccion de conversion (OD) O (DO)");
               
                op = (Console.ReadLine());
                switch (op)
                {
                    case "OD":
                    case "od":
                       
                       Console.Clear();
                        break;
                    case "DO":
                    case "do":
                        
                        break;
                }
            while (op.CompareTo("OD") != 0 && op.CompareTo("od") != 0 && op.CompareTo("DO") != 0 && op.CompareTo("do") != 0)
            {
                op = "";
                System.Console.Clear();
                System.Console.WriteLine("Digite una opcion valida.");
                cardinalidad();
            }
           /* bool a = false;
            if (op.CompareTo("OD") != 0 && op.CompareTo("od") != 0 && op.CompareTo("DO") != 0 && op.CompareTo("do") != 0)
            {
                System.Console.Clear();
                System.Console.WriteLine("AASDASD");
               a = true;
            }
            if (a == true) {
                Console.Clear();
                cardinalidad();
            }*/  

        }
        public int MenuConversion() {
            int opcion = 0;
            int menu = 0;
            Console.WriteLine("\t1 - Dolares Americanos");
            Console.WriteLine("\t2 - Euros");
            Console.WriteLine("\t3 - Yuanes (Renminbi)");
            Console.WriteLine("\t4 - Yenes (Japon)");
            Console.WriteLine("\t5 - Pesos Colombianos");
            Console.Write("Seleccione el tipo de moneda: ");
            string op = Console.ReadLine();
            opcion = Int32.Parse(op);
            switch (opcion) {
                case 1:
                    Console.WriteLine("\t1 - Euros");
                    Console.WriteLine("\t2 - Yuanes (Renminbi)");
                    Console.WriteLine("\t3 - Yenes (Japon)");
                    Console.WriteLine("\t4 - Pesos Colombianos");
                    Console.Write("Seleccione el tipo de moneda al que quiere convertir: ");
                    menu = Int32.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("\t1 - Dolares");
                    Console.WriteLine("\t2 - Yuanes (Renminbi)");
                    Console.WriteLine("\t3 - Yenes (Japon)");
                    Console.WriteLine("\t4 - Pesos Colombianos");
                    Console.Write("Seleccione el tipo de moneda al que quiere convertir: ");
                    menu = Int32.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("\t1 - Dolares");
                    Console.WriteLine("\t2 - Euros");
                    Console.WriteLine("\t3 - Yenes (Japon)");
                    Console.WriteLine("\t4 - Pesos Colombianos");
                    Console.Write("Seleccione el tipo de moneda al que quiere convertir: ");
                    menu = Int32.Parse(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("\t1 - Dolares");
                    Console.WriteLine("\t2 - Euros");
                    Console.WriteLine("\t3 - Yuanes (Renminbi)");
                    Console.WriteLine("\t4 - Pesos Colombianos");
                    Console.Write("Seleccione el tipo de moneda al que quiere convertir: ");
                    menu = Int32.Parse(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("\t1 - Dolares");
                    Console.WriteLine("\t2 - Euros");
                    Console.WriteLine("\t3 - Yuanes (Renminbi)");
                    Console.WriteLine("\t4 - Yenes (Japon)");
                    Console.Write("Seleccione el tipo de moneda al que quiere convertir: ");
                    menu = Int32.Parse(Console.ReadLine());
                    break;
            }
            while(opcion > 5) {
                opcion = 0;
                System.Console.Clear();
                System.Console.WriteLine("Digite una opcion valida.");
                MenuConversion();
            }
            return (menu);


        }
    }

}
