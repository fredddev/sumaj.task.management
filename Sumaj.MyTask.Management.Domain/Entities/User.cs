using System;
using System.Collections.Generic;
using System.Text;

namespace Sumaj.MyTask.Management.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public string Type { get; set; }

        public bool Enabled { get; set; }

    }
}
