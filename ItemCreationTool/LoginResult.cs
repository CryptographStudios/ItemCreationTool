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
    
    public partial class LoginResult
    {
        public int LoginResultId { get; set; }
        public string Result { get; set; }
        public string Details { get; set; }
    
        public virtual LoginHistory LoginHistory { get; set; }
    }
}
