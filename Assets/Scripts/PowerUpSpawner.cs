using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Runtime.InteropServices.WindowsRuntime;
//using Unity.VisualScripting;
//using UnityEngine.Windows;
//using JetBrains.Annotations;

public class PowerUpSpawner : MonoBehaviour
{
    //"[SerializeField]" is used to make the private variables accessible within the Unity inspector without making them public.
    [SerializeField] private GameObject _speedGemPowerUp;
    [SerializeField] private GameObject _healthGemPowerUp;
    private int _randNumber;

    private Rigidbody2D rb;

    private float _powerUpMoveSpeed = 2f; //Private so it cannot be edited outside the PowerUp Spawner class
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn()); // Coroutine for powerups to spawn -> coroutines are used to create a sequence of events over time
    }

    IEnumerator Spawn()
    {
        //While the gameplay is active, powerups will continue to spawn
        Scene scene = SceneManager.GetActiveScene();

        while (scene.buildIndex == 1)
        {

            yield return new WaitForSeconds(10f);
            SpawnPowerUp();
            SceneManager.GetActiveScene();
        }
    }


    // Defining the SpawnItem method vvv
    void SpawnPowerUp()
    {
        // 1st parameter: game object to be created, 2nd parameter: location of the object (Vector2 means only the x- and y-axis), 3rd parameter: object is rotated to match the scene inside the game
        _randNumber = Random.Range(1, 3);

        if (_randNumber == 1)
        {
          Instantiate(_speedGemPowerUp, new Vector2(Random.Range(8.5f, -8.5f), 3), Quaternion.identity);
        }
        else
        {
            Instantiate(_healthGemPowerUp, new Vector2(Random.Range(8.5f, -8.5f), 3), Quaternion.identity);
        }
        
    }

    void Update()
    {
        
    }

}
