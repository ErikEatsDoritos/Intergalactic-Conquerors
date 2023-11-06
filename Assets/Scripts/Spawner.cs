using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject Tier3;
    [SerializeField]
    private GameObject Tier1;
    [SerializeField]
    private GameObject Tier2;
    private float _xAxis; 
    private int _randomRoll;
    private float _SpawnOffset;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGameObjects()); // StartCorutine allows to call the delayed function 
        _randomRoll = Random.Range(1, 4);
        _xAxis = Random.Range(-8f, 8f);
        _SpawnOffset = Random.Range(-2f, 2f);
    }

    public float Get_xAxis()
    {
        return _xAxis;
    }

    public void Set_xAxis(float value)
    {
        
        _xAxis = value + _SpawnOffset;
    }

    public void FlipCoin(int value)
    {
        _randomRoll = value;
    }

    IEnumerator SpawnGameObjects() // IEnumerator allows for methods to be paused and delayed
    {
       
        


        while (true) 
        {
            
            yield return new WaitForSeconds(Random.Range(2, 5)); // one yeild statement is needed for the coroutine to work
            
            if (_randomRoll == 1) 
            { 
                Instantiate(Tier1, new Vector2(_xAxis, 6), Quaternion.identity);
                Debug.Log("Rolled 1");
            }
            else if (_randomRoll == 2) 
            { 
                Instantiate(Tier2, new Vector2(_xAxis, 6), Quaternion.identity);
                Debug.Log("Rolled 2");
            }
            else if (_randomRoll == 3) 
            { 
                Instantiate(Tier3, new Vector2(_xAxis, 6), Quaternion.identity);
                Debug.Log("Rolled 3");
            }
            _SpawnOffset = Random.Range(-2f, 2f);
            Set_xAxis(Random.Range(-10f, 10f));
            FlipCoin(Random.Range(1, 4));
            Debug.Log("called method");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // You can add any necessary update logic here
    }
}
