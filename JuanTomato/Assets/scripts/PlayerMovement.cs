using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private void Start() {
    }
    public PlayerController controller; 
    public float runSpeed = 40f; 
    float horizontalMove = 0f;   
    bool jump = false;   
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed; 

        if(Input.GetButtonDown("Jump")){
            jump = true; 
        }
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
