//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AyupovLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReffilFund
    {
        public int ReffilFundID { get; set; }
        public int FundID { get; set; }
        public int StaffID { get; set; }
        public System.DateTime Data { get; set; }
        public string NameSource { get; set; }
        public int TypeLitID { get; set; }
        public string Publisher { get; set; }
        public System.DateTime DataPublisher { get; set; }
        public int Quantity { get; set; }
    
        public virtual FundLibrary FundLibrary { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual TypeLiteratures TypeLiteratures { get; set; }
    }
}
