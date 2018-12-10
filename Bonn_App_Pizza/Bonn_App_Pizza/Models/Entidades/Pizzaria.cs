namespace Bonn_App_Pizza.Models.Entidades
{
    public class Pizzaria
    {
        public int IdPizzaria { get; set; }
        public string NomeDivulgacao { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Proprietario { get; set; }
        public TpLogradouro TpLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public Municipio Municipio {get; set;}
    }
}
