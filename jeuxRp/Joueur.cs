using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    public class Joueur
    {
        private int _healthPoint;

        public int healthPoint
        {
            get { return _healthPoint; }
        }

        public bool isAlive
        {
            get
            {
                return _healthPoint > 0;
            }
        }

        public Joueur(int healthPoint)
        {
            _healthPoint = healthPoint;
        }

        public void Attack(Monster monster)
        {
            int joueurThrow = this.ThrowDice();
            int monsterThrow = this.ThrowDice();

            if (joueurThrow >= monsterThrow)
            {
                monster.DamageSuffered();
            }
        }

        public void DamageSuffered(int damageSuffered)
        {
            if(!IsShieldWorking())
                _healthPoint -= damageSuffered;
        }

        private bool IsShieldWorking()
        {
            return this.ThrowDice() <= 2;
        }

        public int ThrowDice()
        {
            return De.Rolled();
        }
    }
}
