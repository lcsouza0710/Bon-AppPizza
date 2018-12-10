namespace Bonn_App_Pizza.Models.Entidades
{
    public class Estado
    {
        public int IdEstado { get; set; }
        public string NmEstado { get; set; }
        public string SgEstado { get; set; }
        public Pais Pais { get; set; }
    }
}