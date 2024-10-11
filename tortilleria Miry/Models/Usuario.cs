namespace capaEntidad
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string HashPassword { get; set; }
        public string Rol { get; set; } 
        public DateTime FechaCreacion { get; set; }
    }

}
