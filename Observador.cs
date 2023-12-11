using System.ComponentModel;

public class Observador: IObservador
{
    private String _nombreEstudiante;
    public Observador(string nombreEstudiante)
    {
        _nombreEstudiante = nombreEstudiante;

    }
    public void Actualizar(string nombreProducto, double nuevoPrecio)
    {
        Console.WriteLine(" Estudiante " + _nombreEstudiante + " El precio del videojuego de :" + nombreProducto + " Ah cambiado :" + nuevoPrecio);
        
    }
}