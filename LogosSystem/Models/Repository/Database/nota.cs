
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
    
public partial class nota
{

    public int Nota_ID { get; set; }

    public int Tipo { get; set; }

    public decimal Valor { get; set; }

    public int Aluno_ID { get; set; }

    public int Disciplina_ID { get; set; }

    public int Curso_ID { get; set; }



    public virtual aluno aluno { get; set; }

    public virtual disciplina disciplina { get; set; }

    public virtual curso curso { get; set; }

}

}
