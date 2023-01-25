namespace Hospitales;

public class Trabajadores
{
    public String nombre { get; }
    public String email { get; }
    public bool profesion { get; set; }
    public DateTime inicioTrabajo { get; }
    public decimal salario { get; }
    public int edad { get; }

    public Trabajadores(String nombre, string email, bool profesion, DateTime inicioTrabajo, decimal salario, int edad)
    {
        this.nombre = nombre;
        this.email = email;
        this.profesion = profesion;
        this.inicioTrabajo = inicioTrabajo;
        this.salario = salario;
        this.edad = edad;
    }
    
    public void Profesion()
    {
        profesion =!profesion;
    }

    public String Form()
    {
        return nombre + " " + email + " " + profesion.ToString() + " " + inicioTrabajo.ToString() + " " + salario.ToString() + " " + edad.ToString();
    }
}