/*                                          Anotações
    
    Stack (Pilha de Dados) -> onde temos valores armazenados do type int, bool, double, byte
    
    Heap -> (Objetos / Tipos mais complexos)

    LOH -> (É uma Heap para objetos mutio grandes) >= 85kb
    
 */


using UsuarioLib;

Usuario usuarioNew =
    new Usuario(
        "Gustavo",
        "gustavo@gmail.com",
        new List<string>() { "12345678" });


Usuario usuarioNew2 =
    new Usuario(
        "Rafael",
        "rafael@gmail.com",
        new List<string>() { "44245678" });

//12345678
usuarioNew.ExibeTelefones();

//efetuar a padronizacao = 912345678
usuarioNew.PadronizaTelefones();

//912345678
usuarioNew.ExibeTelefones();