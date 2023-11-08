using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Runtime.InteropServices.WindowsRuntime;
//using Unity.VisualScripting;
//using UnityEngine.Windows;
//using JetBrains.Annotations;

public class GemSpawner : MonoBehaviour
{
    //"[SerializeField]" is used to make the private variables accessible within the Unity inspector without making them public.
    [SerializeField] GameObject _blueGem;
    [SerializeField] GameObject _greenGem;
    private int _randNumber;
    
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
            SpawnGem();
            SceneManager.GetActiveScene();
        }
    }


    // Defining the SpawnItem method vvv
    void SpawnGem()
    {
        // 1st parameter: game object to be created, 2nd parameter: location of the object (Vector2 means only the x- and y-axis), 3rd parameter: object is rotated to match the scene inside the game
        _randNumber = Random.Range(1, 3);

        if (_randNumber == 1)
        {
          Instantiate(_blueGem, new Vector2(Random.Range(8.5f, -8.5f), 4.5f), Quaternion.identity);
        }
        else
        {
            Instantiate(_greenGem, new Vector2(Random.Range(8.5f, -8.5f), 4.5f), Quaternion.identity);
        }
        
    }

}
