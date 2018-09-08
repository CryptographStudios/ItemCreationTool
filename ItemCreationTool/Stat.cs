//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItemCreationTool
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stat()
        {
            this.Characters = new HashSet<Character>();
            this.Items = new HashSet<Item>();
        }
    
        public long StatsId { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Agility { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int ElectricBonus { get; set; }
        public int WaterBonus { get; set; }
        public int FireBonus { get; set; }
        public int EarthBonus { get; set; }
        public int HolyBonus { get; set; }
        public int DarkBonus { get; set; }
        public int Armor { get; set; }
        public int MagicResist { get; set; }
        public int ArmorPenetration { get; set; }
        public int MagicPenetration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Character> Characters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}