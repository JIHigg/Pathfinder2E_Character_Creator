using Pathfinder2E_Core.DTOResources;

namespace Pathfinder2E_Core.DTO
{
    public class ClassDTO
    {
        public string ID { get; set; }
        public ClassDTOData Data { get; set; }
        public string[] Effects { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
