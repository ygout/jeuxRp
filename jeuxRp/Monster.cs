using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    public abstract class Monster
    {
        protected int degats;
        public bool isAlive
        {
            get; private set;
        }

        public Monster()
        {
            isAlive = true;
        }
        public abstract void Attack(Joueur joueur);
        public abstract void DamageSuffered();
        public abstract int ThrowDice();
    }
}
