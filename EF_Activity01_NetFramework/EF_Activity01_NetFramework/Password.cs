//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_Activity01_NetFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Password
    {
        public int BusinessEntityID { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
