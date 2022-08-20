using System.Collections.Generic;

namespace Pathfinder2E_Core.DTOResources
{
    /// <summary>
    /// 'data[]' for ActionDTO
    /// </summary>
    public class ActionDTOData
    {
        //Map 'actionCategory.value'
        public string ActionCategory { get; set; }

        //Map 'actionType.value'
        public string ActionType { get; set; }

        //Map 'actions.value'
        public int Actions { get; set; }

        //Map 'description.value'
        public string Description { get; set; }

        //Map 'requirements'
        public string Requirements { get; set; }

        //Map 'rules[]'
        public IEnumerable<RulesDTO> Rules { get; set; }

        //Map 'source.value'
        public string Source { get; set; }

        //Map 'traits'
        public TraitsDTO Traits { get; set; }

        //Map 'trigger'
        public string Trigger { get; set; }

        //Map 'weapon'  TODO CHANGE TO ITEM MAYBE
        public string Weapon { get; set; }


    }
}
