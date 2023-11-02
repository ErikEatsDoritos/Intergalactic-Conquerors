using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
[System.Serializable]
public class EnemyProperty : MonoBehaviour
{
    
    private int _health;
    
    private int _dmg;
    
    private int _maxHealth;
    [SerializeField()]
    private int Tier;

    public int GetHealth()
    {
        return _health;
    }

    public void SetTier(int tier)
    {
        this.Tier = tier;
    }

    public int GetDmg()
    {
        return _dmg;
    }

    private void Start()
    {
       if(Tier == 1)
        {
            _maxHealth = 1;
            _dmg = 1;

        }
       else if (Tier == 2)
        {
            _maxHealth = 1;
            _dmg = 1;

        }
       else if (Tier == 3)
        {
            _maxHealth = 1;
            _dmg = 1;

        }
        this._health = this._maxHealth;
    }










}


    


    
 
    
        
           
            


