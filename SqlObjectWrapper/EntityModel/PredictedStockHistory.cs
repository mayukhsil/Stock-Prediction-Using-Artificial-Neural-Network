//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SqlObjectWrapper.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class PredictedStockHistory
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public double Close { get; set; }
        public int StockId { get; set; }
    }
}
