using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E_Core.DTOResources
{
    /// <summary>
    /// Traits of Ancestry
    /// </summary>
    public class TraitsDTO
    {
        //Map 'traits.rarity.value'
        public string Rarity { get; set; }
        //Map 'traits.value[]'
        public IEnumerable<string> Value { get; set; }
    }
}
