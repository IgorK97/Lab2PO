using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrDB
{
    internal class Cathedras
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string abbreviation {  get; set;}
        public ICollection<Teachers> Teachers { get; set;}
        public Cathedras()
        {
            Teachers=new List<Teachers>();
        }
    }
}
