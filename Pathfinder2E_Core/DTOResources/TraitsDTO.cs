using System.Collections.Generic;

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
