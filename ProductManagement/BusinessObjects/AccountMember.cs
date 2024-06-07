using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class AccountMember
    {
        public string memberID { get; set; } = null!;
        public string memberPassword {  get; set; } = null!;
        public string fullname { get; set; } = null!;
        public string? email {  get; set; }
        public int? role {  get; set; }
    }
}
