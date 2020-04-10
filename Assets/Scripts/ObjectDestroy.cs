using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Wall.transform.position = new Vector3(21.25f, 0f, 11.5f);
        Destroy(gameObject);
          
    }
}
