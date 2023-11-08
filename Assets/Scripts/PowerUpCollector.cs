using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollector : MonoBehaviour
{
    [SerializeField] private PlayerShip playerShip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("SpeedPowerUp"))
        {
            //neededSpeed = GameObject.FindGameObjectWithTag("MainShip").GetComponent<PlayerShip>();

            Destroy(other.gameObject);
            playerShip.GetSpeed();
            playerShip.SetSpeed(20f);
            //Do not know how to make this work^^^
        }
        else if (other.CompareTag("HealthPowerUp"))
        {
            Destroy(other.gameObject);
            
            int newHealth = playerShip.GetHealth() + 2;
            playerShip.SetHealth(newHealth);
        }
    }
}
