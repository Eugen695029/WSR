//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Result
    {
        public int ID_Result { get; set; }
        public int ID_Registration { get; set; }
        public int ID_Event { get; set; }
        public short BidNumber { get; set; }
        public System.TimeSpan RaceTime { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
