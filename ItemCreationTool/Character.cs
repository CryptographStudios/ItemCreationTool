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
    
    public partial class Character
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Character()
        {
            this.Equipments = new HashSet<Equipment>();
        }
    
        public long CharacterId { get; set; }
        public string Name { get; set; }
        public long BaseStatsId { get; set; }
        public long SkillSetId { get; set; }
        public Nullable<long> ExperienceId { get; set; }
    
        public virtual Experience Experience { get; set; }
        public virtual Stat Stat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipments { get; set; }
    }
}
