using System;

namespace Pathfinder2E_Core.Models
{
    public class AbilityScore
    {
        private int modifier;
        public int Score { get; set; }
        public int Modifier 
        {
            get { return modifier; } 
            set { modifier = Convert.ToInt32(Math.Floor((decimal)(Score - 10) / 2)); } //TODO test and maybe write utility to fix if not accurate
        }

    }
}
