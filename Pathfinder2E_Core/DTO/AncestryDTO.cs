﻿using Pathfinder2E_Core.DTOResources;

namespace Pathfinder2E_Core.DTO
{
    /// <summary>
    /// DTO for Ancestry of Character
    /// </summary>
    public class AncestryDTO
    {
        public string ID { get; set; }
        public AncestryDTOData Data { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
