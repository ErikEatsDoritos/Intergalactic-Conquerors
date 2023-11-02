using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float ScrollSpeed = 2f;
    private Vector2 StartPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * ScrollSpeed * Time.deltaTime);

        if (transform.position.y < -24.97f)
        {
            transform.position = StartPosition;
        }
    }
}
