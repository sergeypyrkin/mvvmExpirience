using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvMTest1.Model
{
    public class Marker
    {
        public int Id { get; set; }
        public int TimeVideo { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public string toString()
        {
            return string.Format("{0} {1} {2} {3}", Id.ToString(), TimeVideo.ToString(), Name.ToString(), SurName.ToString());
        }
    }
}
