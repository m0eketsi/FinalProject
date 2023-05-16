using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAim : MonoBehaviour
{
    public LineRenderer lineRenderer;
    Ray ray;
    RaycastHit hit;
    public GameObject muzzle;
    public GameObject testBlock;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        projectLaser();
        detectHit();
    }
    void projectLaser()
    {
        ray = new Ray(muzzle.transform.position, transform.forward * 5000);
        Debug.DrawRay(muzzle.transform.position, transform.forward * 5000, Color.green);
        lineRenderer.SetPosition(0, muzzle.transform.position);
    }
    void detectHit()
    {
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider)
            {
            lineRenderer.SetPosition(1, hit.point);
            }
        } 
    }
}
