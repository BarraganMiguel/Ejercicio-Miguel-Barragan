public class SujetoObservable
{
    private double _precio;
    private string _nombreProducto;
    private List<IObservador> _observadores = new List<IObservador>();
    public SujetoObservable(string nombre, double precio)
    {
        _nombreProducto = nombre;
        _precio =precio;
    }
    public void Suscribir(IObservador observador)
    {
         _observadores.Add(observador);
    }
        public void Desuscribir(IObservador observador)
    {
         _observadores.Remove(observador);
    }
    public void CambiarPrecio(double nuevoPrecio)
    {
        if(nuevoPrecio != _precio)
        {
            _precio = nuevoPrecio;
            NotificarObservadores();
        }
    }
    private void NotificarObservadores()
    {
        foreach (var observador in _observadores)
        {
            observador.Actualizar(_nombreProducto, _precio);
            
        }
    }
}