using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    class HardMonster : Monster
    {
        public override void Attack(Joueur joueur)
        {
            int joueurThrow = joueur.ThrowDice();
            int monsterThrow = this.ThrowDice();

            if(monsterThrow > joueurThrow)
            {
                joueur.DamageSuffered(_degat);
                joueur.DamageSuffered(MagicAttack());
            }
        }

        public override void DamageSuffered()
        {
            isAlive = false;
        }

        private int MagicAttack()
        {
            int monsterThrow = this.ThrowDice();
            if (monsterThrow != 6)
            {
                return monsterThrow * 5;
            }
            else
                return 0;

   
        }
    }
}
