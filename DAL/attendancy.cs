//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class attendancy
    {
        public int Id { get; set; }
        public System.TimeSpan EnterTime { get; set; }
        public Nullable<System.TimeSpan> ExitTime { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
        public Nullable<int> LessonId { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual lesson lesson { get; set; }
        public virtual user user { get; set; }
    }
}
