using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public float xForce = 5.0f;  
    public float zForce = 5.0f;  
    public float yForce = 5.0f;  
  
    public double distToGround;
    //use this for initialization  
  
    void Start () {  
        distToGround = GetComponent<Collider>().bounds.extents.y;
    }  

    bool IsGrounded() {
        return Physics.Raycast(transform.position, -Vector3.up, (float)(distToGround + 0.1));
    }

    //Update is called once per frame  
    void Update () {  
        
        //this is for x axis' movement  
  
        float x = 0.0f;  
        if (Input.GetKey (KeyCode.A) && IsGrounded()) {  
            x = x - xForce;  
        }  
  
        if (Input.GetKey (KeyCode.D) && IsGrounded()) {  
            x = x + xForce;  
        }  
  
        //this is for z axis' movement  
  
        float z = 0.0f;  
        if (Input.GetKey (KeyCode.S)&& IsGrounded()) {  
            z = z - zForce;  
        }  
  
        if (Input.GetKey (KeyCode.W)&& IsGrounded()) {  
            z = z + zForce;  
        }  
        //this is for z axis' movement  
  
        float y= 0.0f;  
        if (Input.GetKeyDown(KeyCode.Space)&& IsGrounded()) {  
            y = yForce;  
        }  
  
        GetComponent<Rigidbody> ().AddForce (x, y, z);  
    }  
}
