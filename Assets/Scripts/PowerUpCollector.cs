using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollector : MonoBehaviour
{
    PlayerShip neededSpeed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SpeedPowerUp"))
        {
            //neededSpeed = GameObject.FindGameObjectWithTag("MainShip").GetComponent<PlayerShip>();
            
            //PlayerShip.GetSpeed();
            //PlayerShip.SetSpeed(20f);
            //Do not know how to make this work^^^
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("HealthPowerUp"))
        {
            Destroy(other.gameObject);
        }
    }
}
