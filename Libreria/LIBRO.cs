
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Libreria
{

using System;
    using System.Collections.Generic;
    
public partial class LIBRO
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LIBRO()
    {

        this.UBICACIONs = new HashSet<UBICACION>();

    }


    public int idLibro { get; set; }

    public string titulo { get; set; }

    public string isbn { get; set; }

    public int publicacion { get; set; }

    public int idAutor { get; set; }

    public int idEditorial { get; set; }

    public int existencias { get; set; }



    public virtual AUTOR AUTOR { get; set; }

    public virtual EDITORIAL EDITORIAL { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<UBICACION> UBICACIONs { get; set; }

}

}
