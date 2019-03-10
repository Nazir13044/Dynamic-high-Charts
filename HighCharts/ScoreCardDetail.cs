//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HighCharts
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScoreCardDetail
    {
        public long ScoreCardDetailsId { get; set; }
        public System.Guid ScoreCardId { get; set; }
        public long KpiId { get; set; }
        public string Optimization { get; set; }
        public string Frequency { get; set; }
        public int FrequencyInNumber { get; set; }
        public Nullable<decimal> PreviousResult { get; set; }
        public decimal Target { get; set; }
        public Nullable<decimal> CurrentResult { get; set; }
        public Nullable<decimal> Achievement { get; set; }
        public Nullable<decimal> AchievementInPercent { get; set; }
        public Nullable<decimal> Score { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> WeightedScore { get; set; }
        public string KpiOwner { get; set; }
        public string KpiOwnerEmpId { get; set; }
        public System.DateTime AddedDate { get; set; }
        public long AddedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
    
        public virtual ScoreCard ScoreCard { get; set; }
    }
}
