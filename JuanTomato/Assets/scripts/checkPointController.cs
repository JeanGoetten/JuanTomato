using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPointController : MonoBehaviour
{
Animator animFlag; 
AudioSource audioSource; 
public AudioClip checkpointFX; 
bool verify;
private void Start() {
    animFlag = GetComponent<Animator>(); 
    audioSource = GetComponent<AudioSource>(); 
    verify = true; 
}
     private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            animFlag.SetBool("Checked", true); 
            if(verify){
                audioSource.PlayOneShot(checkpointFX); 
                verify = false; 
            }
        }
     }
}
