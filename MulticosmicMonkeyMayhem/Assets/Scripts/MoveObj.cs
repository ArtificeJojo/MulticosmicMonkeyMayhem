using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -.01f);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            GameObject.Destroy(gameObject);
            Debug.Log("Collision");
        }
        else if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player Hit!");
            GameObject.Destroy(gameObject);
        }
        
    }
}
