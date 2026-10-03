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

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(gameObject);
        Debug.Log("Collision");
    }
}
