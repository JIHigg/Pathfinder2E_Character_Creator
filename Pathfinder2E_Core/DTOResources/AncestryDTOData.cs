using System.Collections.Generic;

namespace Pathfinder2E_Core.DTOResources
{
    public class AncestryDTOData
    {
        //Map 'additionalLanguages.Value[]'
        public IEnumerable<string> AdditionalLanguages { get; set; }
        
        //Map 'boosts[]' value
        public IDictionary<int, string> Boosts { get; set; }

        //Map 'description.value'
        public string Description { get; set; }

        //Map 'flaws[].value'
        public IDictionary<int, string> Flaws { get; set; }

        //Map 'hp'
        public int Hp { get; set; }

        //Map 'items'
        public IEnumerable<ItemDTO> Items { get; set; }

        //Map 'languages.value[]'
        public IEnumerable<string> Languages { get; set; }

        //Map 'reach'
        public int Reach { get; set; }

        //Map 'rules[]'
        public IEnumerable<RulesDTO> Rules { get; set; }

        //Map 'size'
        public string Size { get; set; }

        //Map 'source.value'
        public string Source { get; set; }

        //Map 'speed'
        public int Speed { get; set; }

        //Map 'traits'
        public TraitsDTO Traits { get; set; }

        //Map 'vision'
        public string Vision { get; set; }

    }
}
