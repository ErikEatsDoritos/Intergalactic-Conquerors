using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.UI;

[System.Serializable]
public class EnemyProperty : MonoBehaviour
{
    public GameObject Bullet;
    private Rigidbody2D rb;
    private int _health;
    private int _dmg;
    public int _tier;
    private Animator Anim;

    //private int _score = 0;
    //[SerializeField] private Text _scoreText;

    public void TakeDmg(int dmg)
    {
        _health -= dmg;
    }

    public int GetDmg() 
    { 
        return _dmg;  
    }

    public void Attack()
    {
        Vector2 EnemyPos = transform.position;
        EnemyPos.y -= 1;
        Instantiate(Bullet, EnemyPos, Quaternion.identity);
    }

    IEnumerator SpawnProjectile()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 4));
            Attack();
        }
        
    }

    IEnumerator DeathAnimation()
    {
        Anim.SetBool("IsDead", true);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "Projectile")
        {
            TakeDmg(1);

        }
    }

    private void Start()
    {
       if(_tier == 1)
        {
            _health = 1;
            _dmg = 1;

        }
       else if (_tier == 2)
        {
            _health = 2;
            _dmg = 1;

        }
       else if (_tier == 3)
        {
            _health = 3;  

        }
        _dmg = 1;
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        

        StartCoroutine(SpawnProjectile()); // starts a curoutine so bullets can be shot at random intervals



    }

    private void Update()
    {
        // checks if ship is dead or not
        if (this._health <= 0)
        {
            
            StartCoroutine(DeathAnimation());
            //_score += 1;
            //_scoreText.text = "Score: " + _score;

        }
        
        // moves ship down 
        
        rb.velocity = new Vector2(0, -0.5f);
        







    }













}


    


    
 
    
        
           
            


