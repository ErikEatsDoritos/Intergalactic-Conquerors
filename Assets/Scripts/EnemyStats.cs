using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProperty : MonoBehaviour
{
    class EnemyStats
    {
        public int _health;
        public int _dmg;
        public int _maxHealth;
        public int Tier;
         

        public EnemyStats(int tier, int health, int dmg)
        {
            this.Tier = tier;
            if (this.Tier == 1)
            {
                _maxHealth = 3;
                _dmg = 1;
            }
            else if (this.Tier == 2)
            {
                _maxHealth = 4;
                _dmg = 2;
            }
            else if (this.Tier == 3)
            {
                _maxHealth = 5;
                _dmg = 3;
            }
            
        }
        public void TakeDamage(int damage)
        {
            _health -= damage;
        }

        public void Death()
        {
            _health = 0;
        }

        public int GetDmg()
        {
            return _dmg;
        }

    }


    void Start()
    {
        
    }
       
}


    


    // Start is called before the first frame update
    
 
    
        
           
            


