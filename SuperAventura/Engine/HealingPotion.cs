using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class HealingPotion : Item
    {        
        public int AmmountToHeal { get; set; }

        public HealingPotion(int id, string name, string namePlural, int ammountToHeal) : base(id, name, namePlural)
        {
            AmmountToHeal = ammountToHeal;
        }
    }
}
