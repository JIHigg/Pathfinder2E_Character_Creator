using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E_Core.DTOResources
{
    public class ClassDTOData
    {
        public int[] AbilityBoostLevels { get; set; }
        public int[] AncestryFeatLevels { get; set; }
        
        /// <summary>
        /// keys = "advanced", "martial", "simple", "unarmed" => int; "other" => ('name') => string, ('rank') => int
        /// </summary>
        public IDictionary<string, object> Attacks { get; set; }
        public int ClassDC { get; set; }
        
        /// <summary>
        /// key = 'value'
        /// </summary>
        public IDictionary<string, IEnumerable<int>> ClassFeatLevels { get; set; }
        
        /// <summary>
        /// keys = 'heavy', 'light', 'medium', 'unarmored'
        /// </summary>
        public IDictionary<string,int> Defenses { get; set; }
        
        /// <summary>
        /// key = 'value'
        /// </summary>
        public IDictionary<string,string> Description { get; set; }
        
        /// <summary>
        /// key = 'value'
        /// </summary>
        public IDictionary<string, int[]> GeneralFeatLevels { get; set; }
        
        public int HP { get; set; }
        
        public IDictionary<string, ItemDTO> Items { get; set; }
        
        /// <summary>
        /// Key = 'value'
        /// </summary>
        public IDictionary<string, string> KeyAbility { get; set; }
        
        public int Perception { get; set; }
        
        /// <summary>
        /// keys = 'key', 'mode', 'path', 'value'
        /// </summary>
        public IEnumerable<RulesDTO> Rules { get; set; }
        
        /// <summary>
        /// Keys = 'fortitude', 'reflex', 'will'
        /// </summary>
        public IDictionary<string,int> SavingThrows { get; set; }
        
        /// <summary>
        /// Key = 'value'
        /// </summary>
        public IDictionary<string, IEnumerable<int>> SkillFeatLevels { get; set; }

        /// <summary>
        /// Key = 'value'
        /// </summary>
        public IDictionary<string, IEnumerable<int>> SkillIncreaseLevels { get; set; }

        /// <summary>
        /// Key = 'value'
        /// </summary>
        public IDictionary<string, string> Source { get; set; }

        /// <summary>
        /// Keys = 'additional': (int), 'value': (string)
        /// </summary>
        public IDictionary<string,object> TrainedSkills { get; set; }

        /// <summary>
        /// Keys = 'custom': (string), 'rarity': dictionary<string,string> => 'value':string, 'value': string[]
        /// </summary>
        public IDictionary<string, object> Traits { get; set; }

        

    }
}
