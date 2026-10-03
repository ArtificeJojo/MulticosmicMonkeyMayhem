using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Add ui

    public int health = 10;
    MoveObj moveObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void HandleCollision(Collision collision)
    {
        Debug.Log(collision.gameObject.name + "collided");
    }
}
