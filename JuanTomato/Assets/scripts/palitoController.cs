using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palitoController : MonoBehaviour
{
    [Range(0, 100)] public int speed = 10; 
    private void Update() {
        transform.Translate((Vector3.up * Time.deltaTime)*speed);
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.collider.tag == "aparato")
        {
            Destroy(gameObject); 
        }
    }
}
