//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wpf_Admin
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
            this.AttendanceDetails = new HashSet<AttendanceDetails>();
            this.AttendanceMaster = new HashSet<AttendanceMaster>();
        }
    
        public int PersonId { get; set; }
        public string PName { get; set; }
        public string PLastName { get; set; }
        public string PContact { get; set; }
        public string PUserName { get; set; }
        public string PEmail { get; set; }
        public string PPassword { get; set; }
        public int RoleId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceDetails> AttendanceDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceMaster> AttendanceMaster { get; set; }
        public virtual Role Role { get; set; }
    }
}
