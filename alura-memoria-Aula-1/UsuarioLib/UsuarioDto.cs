﻿namespace UsuarioLib;

/*
    DTO - Data Transfer Object
*/

public class UsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public List<string> Telefones { get; set; }
} 