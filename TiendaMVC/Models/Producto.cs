//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.ProductoAlmacen = new HashSet<ProductoAlmacen>();
            this.Etiqueta = new HashSet<Etiqueta>();
        }
    
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public decimal Precio_Coste { get; set; }
        public Nullable<decimal> Precio_Venta { get; set; }
        public int idCategoria { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoAlmacen> ProductoAlmacen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etiqueta> Etiqueta { get; set; }
    }
}
