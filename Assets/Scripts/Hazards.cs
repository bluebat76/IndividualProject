using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    public GameObject[] Hazard;
    public float RangeOne = 1;
    public float RangeTwo = 2;
    public float Spawn;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("HazardSpawns", 3.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void HazardSpawns()
    {
        int RandomHaz = Random.Range(0, Hazard.Length - 1);
        Instantiate(Hazard[RandomHaz], new Vector3(Spawn, 0.5f, Random.Range(RangeOne, RangeTwo)), Hazard[RandomHaz].transform.rotation);
    }
}
