//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectAuto
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Pasporta
    {
        public int idMaster { get; set; }
        public int number { get; set; }
        public int seria { get; set; }
        public string vidan { get; set; }
    
        public virtual Table_Mastera Table_Mastera { get; set; }
    }
}
