using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destoryed Ship");
        }
        else if (collision.tag == "Projectile")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destoryed Bullet");
        }
    }

}
