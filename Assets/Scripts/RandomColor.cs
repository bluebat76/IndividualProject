using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        Color RandomColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );

        gameObject.GetComponent<Renderer>().material.color = RandomColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
