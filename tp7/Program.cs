using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7
{
    class Program
    {
        public enum Nombre { Fabio, Alex, Fede, silvia }
        public enum Apellido { Soto, Cordoba, Perez, Mamani }
        public enum Trabajo { Auxiliar, Administrativo, Ingeniero, Especialista, Investigador }
        public enum Estado { casado, soltero }
        public enum Genero { femenino, masculino }
        struct fecha
        {
           public int dia;
           public int mes;
           public int anio;
        }

        struct Empleado
        {
            public Nombre nombre;
            public Apellido apellido;
            public fecha nacimiento;//fecha de nacimiento
            public Estado civil;
            public Genero sexo;
            public fecha ingreso; //fecha de ingreso a la empresa
            public double sueldoB;
            public Trabajo cargo;

        }

        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            int cant;
            Console.Write("ingrese la cantidad de empleados: ");
            cant = int.Parse(Console.ReadLine());
            double SalarioT=0;
            for (int i = 0; i < cant; i++)
            {
                Empleado nuevo = nuevoEmpleado();
                double salario = 0;
                double adicional = 0;
                listaEmpleados.Add(nuevo);
                Console.Write("\n\n PERSONA: " + (i+1));
                Console.Write("\n Nombre: " + listaEmpleados[i].nombre);
                Console.Write("\n Apellido: " + listaEmpleados[i].apellido);
                Console.Write("\n Fecha de nacimiento: " + listaEmpleados[i].nacimiento.dia +"/" + listaEmpleados[i].nacimiento.mes + "/" + listaEmpleados[i].nacimiento.anio);
                Console.Write("\n Estado Civil: " + listaEmpleados[i].civil);
                Console.Write("\n Sexo: " + listaEmpleados[i].sexo);
                Console.Write("\n Fecha de ingreso a la empresa: " + listaEmpleados[i].ingreso.dia + "/" + listaEmpleados[i].ingreso.mes + "/" + listaEmpleados[i].ingreso.anio);
                Console.Write("\n Sueldo basico: " + listaEmpleados[i].sueldoB);
                Console.Write("\n Cargo: " + listaEmpleados[i].cargo);
                Console.Write("\n Antiguedad: " + (2019 - listaEmpleados[i].ingreso.anio));
                Console.Write("\n Edad: " + (2019 - listaEmpleados[i].nacimiento.anio));
                switch(listaEmpleados[i].nombre)
                {
                    case 0: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                    case (Nombre)1: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                    case (Nombre)2: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                    case (Nombre)3: Console.Write("\n Le falta " + (60 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                }
                //CALCULO EL SALARIO
                if((2019 - listaEmpleados[i].ingreso.anio) < 21)
                {
                    
                    adicional = ((listaEmpleados[i].sueldoB * 0.02) * (2019 - listaEmpleados[i].ingreso.anio));
                    switch (listaEmpleados[i].cargo)
                    {
                        case (Trabajo)2:
                        case (Trabajo)3: adicional=+ (adicional * 0.5); break;
                        //default:;break;
                    }
                    switch (listaEmpleados[i].civil)
                    {
                        case (Estado)0: adicional=+ 50000; break;
                    }
                    salario = listaEmpleados[i].sueldoB + adicional;
                    SalarioT = SalarioT + salario;
                    // Console.Write("\n ADICIONAL: " + adicional);
                    Console.Write("\n Salario: " + salario);
                }
                else
                {
                    adicional = (listaEmpleados[i].sueldoB * 0.25);
                    salario = adicional + listaEmpleados[i].sueldoB;
                    SalarioT = SalarioT + salario;
                   // Console.Write("\n ADICIONAL: " + adicional);
                    Console.Write("\n Salario: " + salario);
                }



            }
            Console.Write("\n*****Total de gasto en salario de los empleados***");
            Console.Write("\nes de: {0,0000}", SalarioT);
            int respuesta;
            Console.Write("\n\nQuiere buscar un empleado en particular? (1 = si y 0 = no) ");
            respuesta = int.Parse(Console.ReadLine());
            if (respuesta ==1)
            {
                int buscar = 0;
                Console.Write("Ingrese el numero del empleado: ");
                buscar = int.Parse(Console.ReadLine());
                for (int i = 0; i < buscar; i++)
                {
                    if ((i + 1) == buscar)
                    {
                        double salario = 0;
                        double adicional = 0;
                        Console.Write("\n\n PERSONA: " + (i + 1));
                        Console.Write("\n Nombre: " + listaEmpleados[i].nombre);
                        Console.Write("\n Apellido: " + listaEmpleados[i].apellido);
                        Console.Write("\n Fecha de nacimiento: " + listaEmpleados[i].nacimiento.dia + "/" + listaEmpleados[i].nacimiento.mes + "/" + listaEmpleados[i].nacimiento.anio);
                        Console.Write("\n Estado Civil: " + listaEmpleados[i].civil);
                        Console.Write("\n Sexo: " + listaEmpleados[i].sexo);
                        Console.Write("\n Fecha de ingreso a la empresa: " + listaEmpleados[i].ingreso.dia + "/" + listaEmpleados[i].ingreso.mes + "/" + listaEmpleados[i].ingreso.anio);
                        Console.Write("\n Sueldo basico: " + listaEmpleados[i].sueldoB);
                        Console.Write("\n Cargo: " + listaEmpleados[i].cargo);
                        Console.Write("\n Antiguedad: " + (2019 - listaEmpleados[i].ingreso.anio));
                        Console.Write("\n Edad: " + (2019 - listaEmpleados[i].nacimiento.anio));
                        switch (listaEmpleados[i].nombre)
                        {
                            case 0: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                            case (Nombre)1: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                            case (Nombre)2: Console.Write("\n Le falta " + (65 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                            case (Nombre)3: Console.Write("\n Le falta " + (60 - (2019 - listaEmpleados[i].nacimiento.anio)) + " años para jubilarse"); break;
                        }
                        //******CALCULO EL SALARIO******
                        if ((2019 - listaEmpleados[i].ingreso.anio) < 21)
                        {
                            adicional = ((listaEmpleados[i].sueldoB * 0.02) * (2019 - listaEmpleados[i].ingreso.anio));
                            switch (listaEmpleados[i].cargo)
                            {
                                case (Trabajo)2:
                                case (Trabajo)3: adicional = +(adicional * 0.5); break;
                                    //default:;break;
                            }
                            switch (listaEmpleados[i].civil)
                            {
                                case (Estado)0: adicional = +50000; break;
                            }
                            salario = listaEmpleados[i].sueldoB + adicional;
                            SalarioT = SalarioT + salario;
                            // Console.Write("\n ADICIONAL: " + adicional);
                            Console.Write("\n Salario: " + salario);
                        }
                        else
                        {
                            adicional = (listaEmpleados[i].sueldoB * 0.25);
                            salario = adicional + listaEmpleados[i].sueldoB;
                            SalarioT = SalarioT + salario;
                            // Console.Write("\n ADICIONAL: " + adicional);
                            Console.Write("\n Salario: " + salario);
                        }
                    }
                }
            }
            else if(respuesta > 1)
            {
                Console.Write("Respuetsa incorecta!!! (1 = SI y 0 = NO)");
            }
            else
            {
                    Console.Write("\n ok, esta bien");
            }
            Console.ReadKey();
        }


        static Empleado nuevoEmpleado()
        {
            Empleado nuevo = new Empleado();
            Random aleatorio = new Random();
            nuevo.nombre = (Nombre) aleatorio.Next(0, 4);
            nuevo.apellido = (Apellido) aleatorio.Next(0, 4);
            nuevo.nacimiento.dia = aleatorio.Next(1, 28);
            nuevo.nacimiento.mes = aleatorio.Next(1, 12);
            nuevo.nacimiento.anio = aleatorio.Next(1970, 2001);
            nuevo.civil = (Estado) aleatorio.Next(0, 2);
            nuevo.sexo = (Genero) aleatorio.Next(0, 2);
            nuevo.ingreso.dia = aleatorio.Next(1, 28);
            nuevo.ingreso.mes = aleatorio.Next(1, 12);
            nuevo.ingreso.anio = aleatorio.Next(1970, 2018);
            nuevo.sueldoB = aleatorio.Next(0, 5000);
            nuevo.cargo = (Trabajo) aleatorio.Next(0, 5);

            // Empleado nuevo = new Empleado(nombre, apellido);
            return nuevo;
        }
        
    }
}

