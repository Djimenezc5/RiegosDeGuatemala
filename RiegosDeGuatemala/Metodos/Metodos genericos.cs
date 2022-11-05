namespace RiegosDeGuatemala.Metodos
{
    public class Metodos_genericos
    {
        public double difereciaMinutos(DateTime fechaInicio, DateTime fechaFin)
        {
            TimeSpan deferencia = fechaFin.Subtract(fechaInicio);
            return deferencia.TotalMinutes;
        }
    }
}
