namespace Pathfinder2E_Core.DTO
{
    /// <summary>
    /// DTO for Archetype from api.pathfinder2.fr/v1/pf2/archetype
    /// </summary>
    public class ArchetypeDTO
    {
        //Map '_id'
        public string ID { get; set; }

        //Map 'content'
        public string Content { get; set; }

        //Map 'name'
        public string Name { get; set; }
    }
}
