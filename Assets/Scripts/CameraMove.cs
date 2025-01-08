using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float moveSpeed = 20f;

    private Vector3 minPos=new(-15,14,-20);
    private Vector3 maxPos=new(2,14,15);
    private Vector3 initPos=new(0,14,0);

    public Vector3 MinPos
    {
        get=> minPos;
        set=> minPos=value;
    }
    public Vector3 MaxPos
    {
        get=> maxPos;
        set=> maxPos=value;
    }

    private void Start()
    {
        transform.position=initPos;
    }

    private void Update()
    {
        float x= Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x<0&&transform.position.x<MinPos.x)
        {
            x = 0;
        }
        if (x>0&&transform.position.x>MaxPos.x)
        {
            x = 0;
        }
        if (z<0&&transform.position.z<MinPos.z)
        {
            z = 0;
        }
        if (z>0&&transform.position.z>MaxPos.z)
        {
            z = 0;
        }
        transform.position= transform.position + new Vector3(x, 0, z) * (moveSpeed* Time.deltaTime);
    }
}
