using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveForward : MonoBehaviour
{

    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //TO MAKE THE OBJECT MOVE FORWARD
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }
}
