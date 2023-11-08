using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerUpCollector : MonoBehaviour
{
    private int _score = 0;
    [SerializeField] Text _scoreText;
    [SerializeField] GameObject _blueGem;
    [SerializeField] GameObject _greenGem;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("BlueGem"))
        {
            Destroy(other.gameObject);
            AddtoScore();
        }
        else if (other.CompareTag("GreenGem"))
        {
            Destroy(other.gameObject);
            AddtoScore();
        }
    }

    public void AddtoScore()
    {
        _score += 1;
        _scoreText.text = "Score: " + _score;
        if (_score >= 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
