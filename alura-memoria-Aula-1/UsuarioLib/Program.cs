/*                                          Anotações
    
    Stack (Pilha de Dados) -> onde temos valores armazenados do type int, bool, double, byte
    
    Heap -> (Objetos / Tipos mais complexos)

    LOH -> (É uma Heap para objetos mutio grandes) >= 85kb
    
 */

using UsuarioLib;

//Usuario usuarioNew =
//    new Usuario(
//        "Gustavo",
//        "gustavo@gmail.com",
//        new List<string>() { "12345678" });



////12345678
//usuarioNew.ExibeTelefones();
 
//usuarioNew.PadronizaTelefones();

////912345678
//usuarioNew.ExibeTelefones();

/*Coordenada coordenada = new Coordenada(153.293, -129.298);
Console.WriteLine(coordenada.GetType().BaseType);*/

FormularioDto dto = new FormularioDto();
dto.Nome = "Gustavo";
dto.Idade = 23;
dto.Cargo = "Programador";
dto.Cpf = "11199988827";

FormularioDto dto2 = new FormularioDto();
dto2.Nome = "Gustavo";
dto2.Idade = 23;
dto2.Cargo = "Programador";
dto2.Cpf = "11199988827";

Console.WriteLine(dto == dto2);