using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -2f);
    }

    private void OntriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Boundary"))
        {

            Destroy(other.gameObject);
        }
        Debug.Log("Called Method");
    }



}
