using System;

namespace SimuladorDeManuelPenalva
{
    class Program
    {
        

        
        

        static void Main(string[] args)

        {
            String seleccion;
            String Formato12Horas;
            String Formato24Horas;
            
            


            Console.Write(" Ingrese La Hora ");
            var hora = int.Parse(Console.ReadLine());
            Console.Write(" Ingrese Los Minutos ");
            var minutos = int.Parse(Console.ReadLine());
            Console.Write(" Ingrese Los Segundos ");
            var segundos = int.Parse(Console.ReadLine());
            Console.Write("Ingresar si es AM o PM ");
            seleccion= Console.ReadLine();
            
            

            if (validarHora(hora) && validarMinutos(minutos) && validarSegundos(segundos) && validarseleccion(seleccion)) 
            {
                Formato12Horas = CrearFormato12Horas(hora, minutos, segundos, seleccion);
                Console.WriteLine($"La hora ingresada es {Formato12Horas}");
                Formato24Horas = CrearFormato24Horas(hora, minutos, segundos, seleccion);
                Console.WriteLine($"La hora en formato 24hs es {Formato24Horas}");
            }
            
            else
            { Console.WriteLine("Algunos de los Datos fueron mal ingresados");

            }
                Console.ReadLine();
            
        





        }

        
       

        //private static string CrearFormato24Horas(int hora, int minutos, int segundos, string seleccion)
        //{
        //    return $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {seleccion.ToUpper()}";
        //}

        private static String CrearFormato12Horas(int hora, int minutos, int segundos, string seleccion)
        {
            return $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {seleccion.ToUpper()}";
        }

        private static string CrearFormato24Horas(int hora, int minutos, int segundos, string seleccion)
        {
            if (seleccion.ToUpper() == "AM")
            {
                if (hora == 12)
                {
                    hora = hora - 12;
                }

            }
            else
            {
                if (hora >= 1 && hora <= 11)
                {
                    hora = hora + 12;
                }
            }
            return
                $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')}";

        }

        private static string Formato12Horas(int hora, int minutos, int segundos, string seleccion) => $"{hora.ToString().PadLeft(2, '0')}:{minutos.ToString().PadLeft(2, '0')}:{segundos.ToString().PadLeft(2, '0')} {seleccion.ToUpper()}";

        private static bool validarseleccion(string seleccion)
        {
            return seleccion.ToUpper() == "AM" || seleccion.ToUpper() == "PM";
        }

        private static bool validarSegundos(int segundos)
        {
            return segundos >= 0 && segundos <= 59;
        }

        private static bool validarMinutos(int minutos)
        {
            return minutos >= 0 && minutos <= 59;
        }

        private static bool validarHora(int hora)
        {
            return hora >= 1 && hora <= 12;
        }
    }
}