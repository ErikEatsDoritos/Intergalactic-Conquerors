using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private int _damage = 2;
    private int _speed = 100;
    // Start is called before the first frame update
    

    public int GetSpeed()
    {
        return _speed;
    }

}
