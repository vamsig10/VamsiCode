//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Theatre
    {
        public int Theatre_Id { get; set; }
        public string Theatre_Name { get; set; }
        public string Theatre_Location { get; set; }
        public string Theatre_Movie_MShow { get; set; }
        public string Theatre_Movie_Matinee { get; set; }
        public string Theatre_Movie_FShow { get; set; }
        public string Theatre_Movie_SShow { get; set; }
    }
}