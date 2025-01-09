using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rb;
    public float JumpForce = 0f;
    public float speed = 0f;
    private float rotSpeed = 123;

    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D)==true)
        {
          Quaternion rot = transform.rotation;
          rot = Quaternion.Euler(rot.eulerAngles + (new Vector3(0, -rotSpeed, 0) * Time.deltaTime));
          rb.MoveRotation(rot);
          //  transform.rotation = rot;
        }
        if (Input.GetKey(KeyCode.W) == true)
        {
          rb.AddForce(transform.forward * speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) == true)
        {
            Quaternion rot = transform.rotation;
            rot = Quaternion.Euler(rot.eulerAngles + (new Vector3(0, rotSpeed, 0) * Time.deltaTime));
            rb.MoveRotation(rot);
          //  transform.rotation = rot;
        }
        if (Input.GetKeyDown(KeyCode.Space) ==true)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}


