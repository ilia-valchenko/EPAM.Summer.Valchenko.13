using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTutorial
{
    public class Avatar
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public string Path { get; set; }
    }
}
