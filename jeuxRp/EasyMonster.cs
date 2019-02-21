using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    public class EasyMonster : Monster
    {
        public override void Attack(Joueur joueur)
        {
            if (this.ThrowDice() > joueur.ThrowDice())
            {
                joueur.DamageSuffered(_degat);
            }
        }

        public override void DamageSuffered()
        {
            isAlive = false;
        }

    }
}
