//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practika1
{
    using System;
    using System.Collections.Generic;
    
    public partial class buyers
    {
        public int ID_buyers { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string surname { get; set; }
        public int ID_orders { get; set; }
    
        public virtual orders orders { get; set; }
    }
}
