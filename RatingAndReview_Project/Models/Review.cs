//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RatingAndReview_Project.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int id { get; set; }
        public string ContentC { get; set; }
        public Nullable<double> Rating { get; set; }
        public Nullable<System.DateTime> DatePost { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> AccountId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Product Product { get; set; }
    }
}
