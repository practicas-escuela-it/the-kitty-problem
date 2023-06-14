using Services;

namespace View
{
    public class TheKittyProblem
    {
        public static void Main()
        {
            new TheKittyProblem().Do();
        }

        private void Do()
        {
            new MainView().Interact();
            Console.WriteLine("1- Buscar taxi");
            Console.WriteLine("1- Cerrar aplicación");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Ingresá tu destino");
                string? destination = Console.ReadLine();

                Console.WriteLine("¿Vas con gato?");
                bool withCat = Console.ReadLine() == "S";

                Taxi taxi = new TaxiFinder(destination, withCat).Find();

                Console.WriteLine($"Taxi encontrado: {taxi.Name} - ${taxi.Price}");
                Console.WriteLine("1- Reservar");
                Console.WriteLine("2- Cancelar");
                if (Console.ReadLine() == "1")
                {
                    new TaxiSelector(taxi).Select();
                }
            }


        }
    }
}


// 1- Buscar taxi
// 2- Cerrar aplicación
// 1

// Ingresá tu destino
// Nuñez

// ¿Vas con gato?
// Si

// Taxi encontrado: Pepe - $xxx
// 1- Reservar
// 2- Cancelar