using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Color color;
    private SpriteRenderer sr;
    private Bullet bulletClass;
    private Rigidbody2D bulletRb;
    public GameObject bulletPrefab;
    private Transform playerTransform;
    private float _speed = 5;
    private int _health = 10;
    private float fireSpeed = 1.0f;
    private float nextFire = 0.0f;
    private Vector3 _movement;
    private bool _isAlive = true;
    private float x;
    private float y;

    [SerializeField] private AudioSource _bulletSoundEffect;

    //public PlayerShip(float speed)
    //{
        //Speed = speed;
    //}



    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        bulletClass = bulletPrefab.GetComponent<Bullet>();

    }

    public void Shoot()
    {
         x = playerTransform.position.x;
         y = playerTransform.position.y;
         GameObject bulletObject = Instantiate(bulletPrefab, new Vector3(x, y, 0), playerTransform.rotation);
         bulletRb = bulletObject.GetComponent<Rigidbody2D>();
         bulletRb.AddForce(transform.up * bulletClass.GetSpeed());
         Debug.Log("Pew");
         _bulletSoundEffect.Play();
       
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
        if (_isAlive == false) {
            IsDead();
        }

        //This way uses translate
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            Move();
        }
        
        if (Input.GetKeyDown("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireSpeed;
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

    public IEnumerator ChangeColor()
    {
        Debug.Log("color");
        sr.color = Color.red;
        yield return new WaitForSeconds(0.20f);
        sr.color = Color.white;
    }

    public int GetHealth()
    {
        return _health;
    }

    public void IsDead()
    {
        Debug.Log("You're dead");
        Destroy(gameObject);
        
    }

    //Upon an enemy object hitting the main ship, I want to get the class of the enemy object, whether it be a bullet or an enemy, and access its attributes
    // from there, I can see how much damage the enemy object holds or effects it might have on the main ship, and then inflict changes according to these attributes
}
