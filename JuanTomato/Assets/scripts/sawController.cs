using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawController : MonoBehaviour
{
    [Range(0, 50)] public float moveSpeed = 2.0f;
    [Range(0, 1000)] public float speedRotation = 1.0f; 
    public Transform leftWayPoint, rightWayPoint; 
    Vector3 localScale; 
    public bool movingRight = true; 
    // public bool movingUP = true; 
    Rigidbody2D rb; 

    // Update is called once per frame
    private void Start() {
        localScale = transform.localScale; 

        rb = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    {
        if(transform.position.x > rightWayPoint.position.x){
            movingRight = false; 
        }
        if(transform.position.x < leftWayPoint.position.x){
            movingRight = true; 
        }
        if(movingRight){
            MoveRight(); 
        }
        else{
            MoveLeft(); 
        }
        // if(transform.position.y > rightWayPoint.position.y){
        //     movingUP = false; 
        // }
        // if(transform.position.y < leftWayPoint.position.y){
        //     movingUP = true; 
        // }
        // if(movingUP){
        //     MoveUP(); 
        // }
        // else{
        //     MoveDown(); 
        // }

        transform.eulerAngles += new Vector3(0, 0, speedRotation);
    }
    void MoveRight(){
        movingRight = true; 
        localScale.x = 1; 
        transform.localScale = localScale; 
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y); 
    }
    void MoveLeft(){
        movingRight = false; 
        localScale.x = -1; 
        transform.localScale = localScale; 
        rb.velocity = new Vector2(localScale.x * moveSpeed, rb.velocity.y); 
    }
    // void MoveUP(){
    //     movingUP = true; 
    //     localScale.y = 1; 
    //     transform.localScale = localScale; 
    //     rb.velocity = new Vector2(rb.velocity.x, localScale.y * moveSpeed); 
    // }
    // void MoveDown(){
    //     movingUP = false; 
    //     localScale.x = -1; 
    //     transform.localScale = localScale; 
    //     rb.velocity = new Vector2(rb.velocity.x, localScale.y * moveSpeed); 
    // }
}
