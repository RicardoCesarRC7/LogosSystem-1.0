
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
    
public partial class curso
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public curso()
    {

        this.turma = new HashSet<turma>();

        this.nota = new HashSet<nota>();

    }


    public int Curso_ID { get; set; }

    public string Nome { get; set; }

    public Nullable<int> Duracao_Semestres { get; set; }

    public Nullable<int> Publico_Alvo { get; set; }

    public string Descricao { get; set; }

    public bool Is_Ativo { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<turma> turma { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<nota> nota { get; set; }

}

}
