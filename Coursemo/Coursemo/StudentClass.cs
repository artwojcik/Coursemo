//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentClass
    {
        public int SCID { get; set; }
        public int STID { get; set; }
        public int CID { get; set; }
        public int YEARS { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
    }
}
