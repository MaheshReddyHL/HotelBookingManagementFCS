//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoomCharge
    {
        public int ChargeID { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public decimal TotalCharge { get; set; }
    
        public virtual HotelRoom HotelRoom { get; set; }
        public virtual RoomService RoomService { get; set; }
    }
}
