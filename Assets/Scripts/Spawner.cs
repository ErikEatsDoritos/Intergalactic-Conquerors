using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Tier3;
    public GameObject Tier1;
    public GameObject Tier2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGameObjects()); // StartCorutine allows to call the delayed function 
    }

    IEnumerator SpawnGameObjects() // IEnumerator allows for methods to be paused and delayed
    {
        while (true) 
        {
            yield return new WaitForSeconds(Random.Range(1, 3)); // one yeild statement is needed for the coroutine to work
            Instantiate(Tier1, new Vector2(Random.Range(-10f, 10f), 4), Quaternion.identity);
            Instantiate(Tier2, new Vector2(Random.Range(-10f, 10f), 4), Quaternion.identity);
            Instantiate(Tier3, new Vector2(Random.Range(-10f, 10f), 4), Quaternion.identity);
            Debug.Log("called method");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any necessary update logic here
    }
}
