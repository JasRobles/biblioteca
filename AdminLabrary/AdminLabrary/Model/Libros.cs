//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLabrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libros
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Libros()
        {
            this.Alquileres = new HashSet<Alquileres>();
        }
    
        public int Id_libro { get; set; }
        public string Nombre { get; set; }
        public int cantidad { get; set; }
        public Nullable<System.DateTime> Año { get; set; }
        public int Numero_edicion { get; set; }
        public int Id_autor { get; set; }
        public int Id_Editorial { get; set; }
        public int Id_categoria { get; set; }
        public Nullable<int> estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alquileres> Alquileres { get; set; }
        public virtual Autores Autores { get; set; }
        public virtual Categorias Categorias { get; set; }
        public virtual Editoriales Editoriales { get; set; }
    }
}
