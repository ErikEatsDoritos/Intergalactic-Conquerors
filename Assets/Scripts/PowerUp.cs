using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    private string _color;
    private string _powerEffect;

    public PowerUp(string color, string powerEffect)
    {
        this._color = color;
        this._powerEffect = powerEffect;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
