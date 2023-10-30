using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    private float _speed = 5;
    private Transform playerTransform;
    private int _health = 1;
    private bool _isAlive;
    private Vector3 _movement;

    //public PlayerShip(float speed)
    //{
        //Speed = speed;
    //}



    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //This way uses translate
        
        float x = Input.GetAxis("Horizontal");
        //Debug.Log(x);
        _movement = new Vector3(x, 0, 0);
        playerTransform.Translate(_movement * _speed * Time.deltaTime);

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
