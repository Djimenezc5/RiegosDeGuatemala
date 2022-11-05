namespace RiegosDeGuatemala.Entidades
{
    public class Respuesta
    {
        public bool exitoso { get; set; }
        public string mensaje { get; set; }
        public object datos { get; set; }
        public Guid token { get; set; }
    }
}
