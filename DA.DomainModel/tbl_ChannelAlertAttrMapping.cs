//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DA.DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ChannelAlertAttrMapping : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ChannelAlertAttrMapping()
        {
            this.tbl_ChannelAlert = new HashSet<tbl_ChannelAlert>();
        }
    
        public int ChannelAlertAttrMapID { get; set; }
        public string ReqReference { get; set; }
        public string MessageDesc { get; set; }
        public Nullable<int> SourceID { get; set; }
        public Nullable<int> ModeTypeID { get; set; }
        public Nullable<int> DestnID { get; set; }
        public Nullable<int> DistributionTypeID { get; set; }
        public Nullable<int> FreqID { get; set; }
        public string IsManual { get; set; }
        public Nullable<int> AttrID1 { get; set; }
        public Nullable<int> AttrID2 { get; set; }
        public Nullable<int> AttrID3 { get; set; }
        public Nullable<int> AttrID4 { get; set; }
        public Nullable<int> AttrID5 { get; set; }
        public Nullable<int> AttrID6 { get; set; }
        public Nullable<int> AttrID7 { get; set; }
        public Nullable<int> AttrID8 { get; set; }
        public Nullable<int> AttrID9 { get; set; }
        public Nullable<int> AttrID10 { get; set; }
        public Nullable<int> AttrValueID1 { get; set; }
        public Nullable<int> AttrValueID2 { get; set; }
        public Nullable<int> AttrValueID3 { get; set; }
        public Nullable<int> AttrValueID4 { get; set; }
        public Nullable<int> AttrValueID5 { get; set; }
        public Nullable<int> AttrValueID6 { get; set; }
        public Nullable<int> AttrValueID7 { get; set; }
        public Nullable<int> AttrValueID8 { get; set; }
        public Nullable<int> AttrValueID9 { get; set; }
        public Nullable<int> AttrValueID10 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChannelAlert> tbl_ChannelAlert { get; set; }
        public virtual tbl_Destination tbl_Destination { get; set; }
        public virtual tbl_DistributionType tbl_DistributionType { get; set; }
        public virtual tbl_FrequencyType tbl_FrequencyType { get; set; }
        public virtual tbl_ModeType tbl_ModeType { get; set; }
        public virtual tbl_Source tbl_Source { get; set; }
        public EntityState EntityState { get; set; }
    }
}
