using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;

[System.Serializable]
public class EnemyProperty : MonoBehaviour
{
    [SerializeField()]
    private GameObject Bullet;
    private Rigidbody2D rb;
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

    public void TakeDmg(int dmg)
    {
        _health -= dmg;
    }

    public void Attack()
    {
        
        Instantiate(Bullet, new Vector2(5, 4), Quaternion.identity);
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
            _maxHealth = 2;
            _dmg = 2;

        }
       else if (Tier == 3)
        {
            _maxHealth = 3;
            _dmg = 3;

        }
        this._health = this._maxHealth;
        
        

        


   

        
    }

    private void Update()
    {
        if (this._health <= 0)
        {
            Destroy(gameObject);
        }
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -0.5f);
        





    }













}


    


    
 
    
        
           
            


