using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class EnemyProperty : MonoBehaviour
{
    public GameObject tier1;
    public GameObject tier2;
    public GameObject tier3;
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
        

        int roll = Random.Range(0, 4);
        if (roll == 1) Instantiate(tier1, new Vector2(Random.Range(0f, 10f), 4), Quaternion.identity);
        else if (roll == 2) Instantiate(tier2, new Vector2(Random.Range(0f, 10f), 4), Quaternion.identity);
        else if (roll == 3) Instantiate(tier3, new Vector2(Random.Range(0f, 10f), 4), Quaternion.identity);




    }



    void Update()
    {
        
    }

}


    


    // Start is called before the first frame update
    
 
    
        
           
            


