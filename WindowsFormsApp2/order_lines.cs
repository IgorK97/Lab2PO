//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_lines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_lines()
        {
            this.ingredients = new HashSet<ingredients>();
        }
    
        public int id { get; set; }
        public int ordersId { get; set; }
        public int pizzaId { get; set; }
        public int quantity { get; set; }
        public bool custom { get; set; }
        public decimal position_price { get; set; }
        public int pizza_sizesId { get; set; }
        public decimal weight { get; set; }
    
        public virtual orders orders { get; set; }
        public virtual pizza pizza { get; set; }
        public virtual pizza_sizes pizza_sizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ingredients> ingredients { get; set; }
    }
}
