using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    
    public GameObject Trigger;
    public float WallStartLoc;
    public float WallEndLoc;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Trigger != null)
        {
            
        }
        else
        {
            Wallmovement();
        }


    }

    void Wallmovement()
    {
        if (transform.position.x > WallEndLoc)
        {
            transform.Translate(Vector3.right * Time.deltaTime * Speed);
        }
        
   
    }
}

