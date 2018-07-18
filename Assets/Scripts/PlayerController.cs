using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;
    public float JumpTimer;

    void start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }	

	void Update ()
    {
        float Translation = Input.GetAxis("Vertical") * Speed;
        float Straffe = Input.GetAxis("Horizontal") * Speed;
        
        Translation *= Time.deltaTime;
        Straffe *= Time.deltaTime;
       
        transform.Translate(Straffe, 0, Translation);

        JumpTimer -= Time.deltaTime;

        if(JumpTimer > 1)
        {
            float up = Input.GetAxis("Jump") * JumpSpeed;
            Jump *= Time.deltaTime;
        }

        if(Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
       	
	}
}
