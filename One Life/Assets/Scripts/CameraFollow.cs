using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float XrotateSpeed = 1f, YrotateSpeed =5f;
    public Transform cameraTarget;
    public Transform anchor;
 
    void Awake()
    {
        Cursor.visible = false;
    }
 
    void Update ()
    {
 
        //Rotate Camera
        float cameraXrotFactor = Input.GetAxis("xboxLookHor") * XrotateSpeed;
        float cameraYrotFactor = Input.GetAxis("xboxLookVert") * YrotateSpeed;
        Camera.main.transform.RotateAround(anchor.position, Vector3.up, cameraXrotFactor);
        Camera.main.transform.RotateAround(anchor.position, Vector3.left, cameraYrotFactor);
        Camera.main.transform.LookAt(cameraTarget);
    }
}