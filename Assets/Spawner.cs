using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, 3f);
    }

    void SpawnObject()
    {
        Instantiate(ObjectToSpawn, gameObject.transform.position, gameObject.transform.rotation);
    }
}
