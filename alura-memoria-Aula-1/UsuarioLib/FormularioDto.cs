namespace UsuarioLib
{
    public record FormularioDto
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
    }
}
