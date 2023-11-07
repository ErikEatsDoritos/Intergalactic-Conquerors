using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private Color _color;
    private SpriteRenderer _sr;
    private Bullet _bulletClass;
    private Rigidbody2D _bulletRb;
    public GameObject BulletPrefab;
    private Transform _playerTransform;
    private float _speed = 5;
    private int _health = 1;
    private float _fireSpeed = 1.0f;
    private float _nextFire = 0.0f;
    private Vector3 _movement;
    private bool _isAlive;
    private float _x;
    private float _y;

    //public PlayerShip(float speed)
    //{
        //Speed = speed;
    //}



    // Start is called before the first frame update
    void Start()
    {
        _playerTransform = GetComponent<Transform>();
        _sr = GetComponent<SpriteRenderer>();
        _bulletClass = BulletPrefab.GetComponent<Bullet>();

    }

    public void Shoot()
    {
         _x = _playerTransform.position.x;
         _y = _playerTransform.position.y;
         GameObject bulletObject = Instantiate(BulletPrefab, new Vector3(_x, _y, 0), _playerTransform.rotation);
         _bulletRb = bulletObject.GetComponent<Rigidbody2D>();
         _bulletRb.AddForce(transform.up * _bulletClass.GetSpeed());
         Debug.Log("Pew");
       
    }

    public void Move()
    {
        float x = Input.GetAxis("Horizontal");
        _movement = new Vector3(x, 0, 0);
        _playerTransform.Translate(_movement * _speed * Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        //This way uses translate
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            Move();
        }
        
        if (Input.GetKeyDown("space") && Time.time > _nextFire)
        {
            _nextFire = Time.time + _fireSpeed;
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
        _sr.color = Color.red;
        yield return new WaitForSeconds(0.20f);
        _sr.color = Color.white;
    }

    public int GetHealth()
    {
        return _health;
    }

    //Upon an enemy object hitting the main ship, I want to get the class of the enemy object, whether it be a bullet or an enemy, and access its attributes
    // from there, I can see how much damage the enemy object holds or effects it might have on the main ship, and then inflict changes according to these attributes
}
