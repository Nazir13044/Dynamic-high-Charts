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
    
    public partial class ScoreCard
    {
        public ScoreCard()
        {
            this.ScoreCardDetails = new HashSet<ScoreCardDetail>();
        }
    
        public System.Guid ScoreCardId { get; set; }
        public string ScoreCardTypeId { get; set; }
        public string ScoreCardName { get; set; }
    
        public virtual ICollection<ScoreCardDetail> ScoreCardDetails { get; set; }
    }
}
