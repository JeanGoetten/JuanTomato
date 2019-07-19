using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerController controller; 
    public float runSpeed = 40f; 
    float horizontalMove = 0f;   
    bool jump = false;   
    private void Start() {
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            jump = true; 
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; 
    }
    private void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);    
        jump = false; 
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "ketchup"){
            jump = true; 
        }
    }
}
