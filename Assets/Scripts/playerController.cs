using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.right * speed);
        transform.Rotate(Vector3.forward);
    }
}
