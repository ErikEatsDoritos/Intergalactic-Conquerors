using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] GameObject _speedGemPowerUp;
    [SerializeField] GameObject _healthGemPowerUp;
    //"[SerializeField]" is used to make the private variables accessible within the Unity editor without making them public.
    
    // Start is called before the first frame update
    void Start()
    {
        //While the gameplay is active, powerups will continue to spawn
        Scene scene = SceneManager.GetActiveScene();
        
        if (scene.buildIndex == 1)
        {
            SpawnItem();
        }
    }


    // Defining the SpawnItem method vvv
    void SpawnItem()
    {
        // 1st parameter: game object to be created, 2nd parameter: location of the object (Vector2 means only the x- and y-axis), 3rd parameter: object is rotated to match the scene inside the game
        Instantiate(_speedGemPowerUp, new Vector2(Random.Range(8.5f, -8.5f), 3), Quaternion.identity);
        Instantiate(_healthGemPowerUp, new Vector2(Random.Range(8.5f, -8.5f), 3), Quaternion.identity);
    }

}
