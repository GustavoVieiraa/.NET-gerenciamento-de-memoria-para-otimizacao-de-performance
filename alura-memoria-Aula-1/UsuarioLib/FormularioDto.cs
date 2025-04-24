namespace UsuarioLib
{
    /* Essa estrutura é imutavel. 
     * Isso é a garantia da unicidade, ou seja, 
     * Ninguém vai conseguir fazer nenhum tipo de alteração nos meus dados. 
     */
    public record FormularioDto(string Nome, string Cpf, int Idade, string Cargo);
    
}
