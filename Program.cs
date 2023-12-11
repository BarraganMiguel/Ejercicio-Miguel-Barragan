class Program 
{
    static void Main (string[] args)
    {
        SujetoObservable Valorant = new SujetoObservable(" Valorant" , 50.00);
        Observador estudiante1 = new Observador(" Estudiante Miguel");
        Valorant.Suscribir(estudiante1);
        ModificarPrecioPorConsola(Valorant);

        SujetoObservable Fifa2020 = new SujetoObservable(" Fifa2020" , 100.00);
        Observador estudiante2 = new Observador(" Estudiante Franklin");
        Fifa2020.Suscribir(estudiante2);
        ModificarPrecioPorConsola(Fifa2020);

        static void ModificarPrecioPorConsola( SujetoObservable producto)
        {
            Console.WriteLine(" Modifiando el precio del videojuego" + producto);
            Console.WriteLine (" Nuevo Precio es:");
            double nuevoPrecio;
            if(double.TryParse(Console.ReadLine(), out nuevoPrecio))
            {
                producto.CambiarPrecio(nuevoPrecio);
            }
        }
    }
}
