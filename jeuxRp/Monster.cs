using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    public abstract class Monster
    {
        protected const int _degat = 10;

        public bool isAlive
        {
            get; protected set;
        }

        public Monster()
        {
            isAlive = true;
        }
        public abstract void Attack(Joueur joueur);
        public abstract void DamageSuffered();

        public int ThrowDice()
        {
            return De.Rolled();
        }
    }
}
