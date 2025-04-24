using UsuarioLib;

Usuario usuarioNew =
    new Usuario(
        "Gustavo",
        "gustavo@gmail.com",
        new List<string>() { "12345678" });


//12345678
usuarioNew.ExibeTelefones();

//efetuar a padronizacao = 912345678
usuarioNew.PadronizaTelefones();

//912345678
usuarioNew.ExibeTelefones();