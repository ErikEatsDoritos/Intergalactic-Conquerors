using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Bullet bulletClass;
    private float _speed = 5;
    private Transform playerTransform;
    private Rigidbody2D rb;
    private int _health = 1;
    private bool _isAlive;
    private Vector3 _movement;
    public GameObject bulletPrefab;
    private float x;
    private float y;

    //public PlayerShip(float speed)
    //{
        //Speed = speed;
    //}



    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        bulletClass = bulletPrefab.GetComponent<Bullet>();
        
    }

    public void Shoot()
    {
 
         x = playerTransform.position.x;
         y = playerTransform.position.y;
         GameObject bulletObject = Instantiate(bulletPrefab, new Vector3(x, y, 0), playerTransform.rotation);
         rb = bulletObject.GetComponent<Rigidbody2D>();
         rb.AddForce(transform.up * bulletClass.GetSpeed());
         Debug.Log("Pew");
       
    }

    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        _movement = new Vector3(x, 0, 0);
        playerTransform.Translate(_movement * _speed * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        //This way uses translate
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            Move();
        }
        
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
        //Debug.Log(x);
        

        //This way uses add force

        //float x = Input.GetAxis("Horizontal");
        //if (Input.GetButton("Horizontal"))
        //{
        //rb.AddForce(transform.right * x * speed);
        //}

    }


    

    public void TakeDamage(int damage)
    {
        this._health -= damage;
        if (this._health < 0) {
            this._isAlive = false;
            Debug.Log(_isAlive);
        }
        
    }

    public int GetHealth()
    {
        return _health;
    }

    //Upon an enemy object hitting the main ship, I want to get the class of the enemy object, whether it be a bullet or an enemy, and access its attributes
    // from there, I can see how much damage the enemy object holds or effects it might have on the main ship, and then inflict changes according to these attributes
}
