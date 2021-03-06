//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTGCM
{
    using System;
    using System.Collections.Generic;
    
    public partial class CardBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CardBase()
        {
            this.OwnedCard = new HashSet<OwnedCard>();
            this.CardSubtype = new HashSet<CardSubtype>();
            this.CardType = new HashSet<CardType>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string oracle_text { get; set; }
        public string power { get; set; }
        public string toughness { get; set; }
        public string mana_cost { get; set; }
        public Nullable<decimal> cmc { get; set; }
        public Nullable<long> fk_language_id { get; set; }
        public string image { get; set; }
        public Nullable<long> fk_artist_id { get; set; }
        public Nullable<long> fk_rarity_id { get; set; }
        public Nullable<long> fk_set_id { get; set; }
        public string flavor_text { get; set; }
        public string number { get; set; }
        public Nullable<long> version { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Set Set { get; set; }
        public virtual Rarity Rarity { get; set; }
        public virtual Language Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OwnedCard> OwnedCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardSubtype> CardSubtype { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CardType> CardType { get; set; }
    }
}
