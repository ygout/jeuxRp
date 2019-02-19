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
        private bool _isAlive;

        public int healthPoint
        {
            get { return _healthPoint; }
        }

        public bool isAlive
        {
            get
            {
                return _isAlive;
            }
        }

        public Joueur()
        {
            _healthPoint = 150;
        }

        public void Attack()
        {

        }

        public void DamageSuffered(int damageSuffered)
        {

        }
    }
}
