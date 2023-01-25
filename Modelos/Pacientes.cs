namespace Hospitales;

public class Pacientes{
    public String nombre { get; }
    public String apellido { get; }
    public bool alta_baja { get;set; }
    public DateTime fecha_ingreso { get; }
    public decimal peso { get; }
    public int edad { get; }

    public Pacientes(String nombre, string apellido, bool alta_baja, DateTime fecha_ingreso, decimal peso, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.alta_baja = alta_baja;
        this.fecha_ingreso = fecha_ingreso;
        this.peso = peso;
        this.edad = edad;
    }
    
    public void Alta_baja()
    {
        alta_baja =!alta_baja;
    }

    public String Form()
    {
        return nombre + " " + apellido + " " + alta_baja.ToString() + " " + fecha_ingreso.ToString() + " " + peso.ToString() + " " + edad.ToString();
    }
}