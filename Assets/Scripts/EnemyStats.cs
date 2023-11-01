using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class EnemyProperty : MonoBehaviour
{
    class EnemyStats
    {
        [SerializeField()]
        private int _health;
        [SerializeField()]
        private int _dmg;
        [SerializeField()]
        private int _maxHealth;
        [SerializeField()]
        private int Tier;
        
        
        public EnemyStats(int tier)
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
            _health = _maxHealth;

            
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



    void Update()
    {
        
    }

}


    


    // Start is called before the first frame update
    
 
    
        
           
            


