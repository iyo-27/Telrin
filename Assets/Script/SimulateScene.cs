using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimulateScene : MonoBehaviour
{
    public GameObject lightPrefabB;
    public GameObject lightPrefabR;
    public GameObject lightPrefabL;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(lightPrefabB, new Vector3( 0.16f, 1.10f, 4.87f), Quaternion.identity);
        Instantiate(lightPrefabR, new Vector3( 0.9f, 0.97f, 3.55f), Quaternion.identity);
        Instantiate(lightPrefabL, new Vector3( -0.9f, 0.97f, 3.55f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
