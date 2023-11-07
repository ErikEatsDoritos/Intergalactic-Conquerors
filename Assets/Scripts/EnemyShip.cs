using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private int _damage = 2;
    private int _health = 100;
    private GameObject _playerShip;
    private PlayerShip _playerInstance;

    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Attack()
    {
        _playerInstance.TakeDamage(_damage);
        StartCoroutine(_playerInstance.ChangeColor());

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerShip>())
        {
            _playerInstance = collision.gameObject.GetComponent<PlayerShip>();
            Attack();
            Debug.Log(_playerInstance.GetHealth());
        }
    }

}