using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemySpawner : MonoBehaviour
{

    
    public GameObject myprefab;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        
        Instantiate(myprefab, new Vector2(Random.Range(0f, 5f), 2), Quaternion.identity);
        Instantiate(prefab2, new Vector2(Random.Range(0f,5f), 2), Quaternion.identity);

    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
