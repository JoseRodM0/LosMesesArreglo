namespace LosMesesArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            string[] losMeses = new string[12];

            losMeses[0] = "Enero";
            losMeses[1] = "Febrero";
            losMeses[2] = "Marzo";
            losMeses[3] = "Abril";
            losMeses[4] = "Mayo";
            losMeses[5] = "Junio";
            losMeses[6] = "Julio";
            losMeses[7] = "Agosto";
            losMeses[8] = "Septiembre";
            losMeses[9] = "Octubre";
            losMeses[10] = "Noviembre";
            losMeses[11] = "Diciembre";

            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 12)
            {
                Console.WriteLine(losMeses[result - 1]);
            }
            else
            {
                Console.WriteLine("Dato incorrecto");
            }
        }
    }
}
