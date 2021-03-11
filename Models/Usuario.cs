namespace ProjetoMVC.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }
        public int Pessoas { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Texto_descricao { get; set; }
    }
}