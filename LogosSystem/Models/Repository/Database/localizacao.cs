
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
    
public partial class localizacao
{

    public int Localizacao_ID { get; set; }

    public string Endereco { get; set; }

    public string Endereco_Complemento { get; set; }

    public string Bairro { get; set; }

    public string Cidade { get; set; }

    public string Estado { get; set; }

    public string CEP { get; set; }

    public int Pais_ID { get; set; }



    public virtual nacao nacao { get; set; }

}

}
