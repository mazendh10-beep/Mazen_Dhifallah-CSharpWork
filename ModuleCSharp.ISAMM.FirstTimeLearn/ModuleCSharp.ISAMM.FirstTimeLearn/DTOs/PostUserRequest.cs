using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleC_.ISAMM.COCOJV.DTOs
{
    public class PostUserRequest()
    {
        public required string? username { get; set; }
        public required string? password { get; set; }
        public string? region { get; set; }
        public int? age { get; set; }
        public required string? Email { get; set; }
    }
}
