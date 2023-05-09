using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{   
public float MoveSpeed = 50;
public float MaxSpeed = 15;
public float Drag = 0.98f;
public float SteerAngle = 20;
public float traction = 1;
private Vector3 MoveForce;
public InputMaster driftAction;
    void Update()
    {
        Moving();
        Steering();
        DragnSpeed();
        Traction();
    }
    public void Moving()
    {
        MoveForce += transform.forward * MoveSpeed * Time.deltaTime;
        transform.position += -MoveForce * Time.deltaTime;
    }
    public void Steering()
    {
        float steerInput = Input.GetAxis("driftHorizontal");
        transform.Rotate(Vector3.up * steerInput * MoveForce.magnitude * SteerAngle * Time.deltaTime);
    }
    public void DragnSpeed()
    {
        MoveForce *= Drag;
        MoveForce = Vector3.ClampMagnitude(MoveForce, MaxSpeed);
    }
    public void Traction()
    {
    Debug.DrawRay(transform.position, MoveForce.normalized * 3);
    Debug.DrawRay(transform.position, transform.forward * 3, Color.blue);
    MoveForce = Vector3.Lerp(MoveForce.normalized, transform.forward, traction * Time.deltaTime) * MoveForce.magnitude;
    }
}