using Hospitales;
using Spectre.Console;

public class Especialidades
{
    public String nombreEspecialidad { get; }
    public String descripcion { get; }
    public bool rotativa { get; set; }
    public DateTime inicioEspecialidad { get; }
    public decimal salario { get; }
    public int afiliados { get; }

    public Especialidades(String nombreEspecialidad, string descripcion, bool rotativa, DateTime inicioEspecialidad, decimal salario, int afiliados)
    {
        this.nombreEspecialidad = nombreEspecialidad;
        this.descripcion = descripcion;
        this.rotativa = rotativa;
        this.inicioEspecialidad = inicioEspecialidad;
        this.salario = salario;
        this.afiliados = afiliados;
    }
    
    public void rotativaE()
    {
        rotativa =!rotativa;
    }

    public String formE()
    {
        return nombreEspecialidad + " " + descripcion + " " + rotativa.ToString() + " " + inicioEspecialidad.ToString() + " " + salario.ToString() + " " + afiliados.ToString();
    }

}