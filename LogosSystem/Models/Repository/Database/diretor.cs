
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LogosSystem.Models.Repository.Database
{

using System;
    using System.Collections.Generic;
    
public partial class diretor
{

    public int Diretor_ID { get; set; }

    public string Primeiro_Nome { get; set; }

    public string Segundo_Nome { get; set; }

    public System.DateTime Data_Nascimento { get; set; }

    public string Email { get; set; }

    public string Telefone { get; set; }

    public string Celular { get; set; }

    public string RG { get; set; }

    public string CPF { get; set; }

    public int Nacao_ID { get; set; }

    public int Posicao { get; set; }

    public string Formacao_Descricao { get; set; }

    public string CidadeNascimento { get; set; }

    public int Idade { get; set; }

    public int Sexo { get; set; }

    public string Pai_Nome { get; set; }

    public string Mae_Nome { get; set; }

    public string EnderecoComercial { get; set; }

    public string TelefoneComercial { get; set; }

    public string Profissao { get; set; }

    public Nullable<int> Estado_Civil { get; set; }

    public Nullable<int> Filhos_Qtt { get; set; }

    public string Conjuge_Nome { get; set; }

    public bool Is_Professor { get; set; }



    public virtual nacao nacao { get; set; }

}

}
