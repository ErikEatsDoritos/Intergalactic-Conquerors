using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private int _damage;
    private int _health = 100;
    private GameObject _playerShip;
    private PlayerShip _playerInstance;
    private EnemyProperty _enemyProperty;
    public GameObject tier1;
    
    private EnemyProperty _enenmyStatsClass;
    private int _enemyDmg; 




    private void Start()
    {
        _enenmyStatsClass = tier1.GetComponent<EnemyProperty>();
        _enemyDmg = _enenmyStatsClass.GetDmg();

        // gets values from enemy damage scrip
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void Attack()
    {
        
        _playerInstance.TakeDamage(_enemyDmg);
        StartCoroutine(_playerInstance.ChangeColor());
        Debug.Log(_enemyDmg);

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