using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private int _damage = 2;
    private Transform _enemyTransform;
    private GameObject _playerShip;
    private PlayerShip _playerInstance;

    private void Start()
    {
        _enemyTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime);
    }

    public void Attack()
    {
        _playerInstance.TakeDamage(_damage);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _playerShip = collision.gameObject;
        _playerInstance = _playerShip.GetComponent<PlayerShip>();

        Attack();
        Debug.Log(_playerInstance.GetHealth());
    }

}