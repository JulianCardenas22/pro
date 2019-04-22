using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pro.Model
{
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.Now;
            LastUpdatedDate = DateTime.Now;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
