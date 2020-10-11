using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed;
    public bool right;
    void Start()
    {
        if(!right)
        {
            transform.Rotate(Vector3.back * 180);
        }
    }


    void Update()
    {
        transform.Translate(Vector3.right * speed); //forward is left back is right
        //transform.Rotate(Vector3.forward);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        DirectionalNode dn = other.GetComponent<DirectionalNode>();
        Debug.Log(dn.current);

        //check direction
        float rotate = 0;
        Vector3 dir = Vector3.zero;
        if (dn.current == "right")
        {
            dir = Vector3.back;
            rotate = 90;
        }
        else if (dn.current == "left")
        {
            dir = Vector3.forward;
            rotate = 90;
        }

        transform.Rotate(dir * rotate);
    }
}
