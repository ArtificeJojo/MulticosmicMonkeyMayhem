using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject asteroid1;
    private MoveObj moveObj;
    
    private float minX = -25.37f, maxX = 25.55f, minY = -8.45f, maxY = 14.24f;
    private float minZ = 92.3f, maxZ = 93.3f;

    private int objNo = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objNo < 5)
            SpawnObj();
    }

    void SpawnObj()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        float z = Random.Range(minZ, maxZ);
        
        Vector3 pos = new Vector3(x,y,z);
        Instantiate(asteroid1, pos, Quaternion.identity);
        objNo++;
    }
}
