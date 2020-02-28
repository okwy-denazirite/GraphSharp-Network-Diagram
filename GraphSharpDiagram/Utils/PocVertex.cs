using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSharpDiagram
{
    /// <summary>
    /// A simple identifiable vertex.
    /// </summary>
    [DebuggerDisplay("{ID}-{Facility}")]
    public class PocVertex
    {
        public string ID { get; private set; }
        public string Visibl { get; private set; }
        public int Facility { get; private set; }
        public List<int> children { get; set; }       
        public PocVertex(string id, int facility = 1)
        {
            ID = id;
            Facility = facility;
            Visibl = "Collapsed";
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}", ID, Facility);
        }
    }
}
