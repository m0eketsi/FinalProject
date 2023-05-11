using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMove : MonoBehaviour
{
     //  e.g. 0.2 = slow, 0.8 = fast, 2 = very fast, Infinity = instant
[Tooltip("If rotationSpeed == 0.5, then it takes 2 seconds to spin 180 degrees")]
[SerializeField] [Range(0, 10)] float rotationSpeed = 0.5f;
 
[Tooltip("If isInstant == true, then rotationalSpeed == Infinity")]  
[SerializeField] bool isInstant = false;
public Camera _camera;
 
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = false;
    }
 
    void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        Quaternion targetRotation = Quaternion.LookRotation(ray.direction);
        transform.rotation = targetRotation;
    }
}
