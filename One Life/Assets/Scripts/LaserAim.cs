using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAim : MonoBehaviour
{
    public LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
    lineRenderer.useWorldSpace = false;
    RaycastHit hit;
    Physics.Raycast(transform.position,transform.forward, hit.point);
    if(hit.collider){
    lineRenderer.SetPosition(1,Vector3(0,0,hit.distance));
    }
    else{
    lineRenderer.SetPosition(1,Vector3(0,0,5000));
    }
    }*/
}
