using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallContact : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
