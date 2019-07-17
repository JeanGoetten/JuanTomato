using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class palitoController : MonoBehaviour
{
    [Range(0, 100)] public int speed = 10; 
    private void Update() {
        transform.Translate((Vector3.up * Time.deltaTime)*speed);
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "aparato"){
            Destroy(gameObject); 
        }
    }
}
