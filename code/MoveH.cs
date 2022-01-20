using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{

    public float speed = 1.0f;
    // Start is called before the first frame update
    


   
    void Update()
    {
        this.transform.Translate(speed / 50, 0,0);
    }
}
