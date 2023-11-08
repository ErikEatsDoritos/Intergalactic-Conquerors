using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerUpCollector : MonoBehaviour
{
    private int _score = 0;
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _speedGemPowerUp;
    [SerializeField] private GameObject _healthGemPowerUp;

    //[SerializeField] private PlayerShip playerShip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("SpeedPowerUp"))
        {
            //neededSpeed = GameObject.FindGameObjectWithTag("MainShip").GetComponent<PlayerShip>();

            Destroy(other.gameObject);
            AddtoScore();
            //playerShip.GetSpeed();
            //playerShip.SetSpeed(20f);
            //Do not know how to make this work^^^
        }
        else if (other.CompareTag("HealthPowerUp"))
        {
            Destroy(other.gameObject);
            AddtoScore();
            //int newHealth = playerShip.GetHealth() + 2;
            //playerShip.SetHealth(newHealth);
        }
    }

    public void AddtoScore()
    {
        _score += 1;
        _scoreText.text = "Score: " + _score;
        if (_score >= 10)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
