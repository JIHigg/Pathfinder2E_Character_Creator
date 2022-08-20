using Pathfinder2E_Core.DTOResources;
using System.Collections.Generic;

namespace Pathfinder2E_Core.DTO
{
    /// <summary>
    /// DTO for Action from api.pathfinder2.fr/v1/pf2/action API
    /// </summary>
    public class ActionDTO
    {
        //Map '_id'
        public string ID { get; set; }

        //Map 'data[]'
        public ActionDTOData Data { get; set; }

        //Map 'effects[]'
        public IEnumerable<string> Effects { get; set; }

        //Map 'name'
        public string Name { get; set; }

        //Map 'type'
        public string Type { get; set; }
    }
}
