//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataSets
    {
        public System.Guid ID { get; set; }
        public System.Guid ItemID { get; set; }
        public Nullable<System.Guid> LinkID { get; set; }
        public string Name { get; set; }
    
        public virtual Catalog Catalog { get; set; }
        public virtual Catalog Catalog1 { get; set; }
    }
}
