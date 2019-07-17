using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointController : MonoBehaviour
{
Animator animFlag; 
private void Start() {
    animFlag = GetComponent<Animator>(); 
}
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            animFlag.SetBool("Checked", true); 
        }
     }
}
