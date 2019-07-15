using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject spawnPoint; 
    Transform lastSave; 
    private int sal = 0; 
    private void Start() {
        lastSave = spawnPoint.transform;
    }
    private void OnCollisionEnter2D(Collision2D other){
        if(other.collider.tag == "spawnpoint"){
            lastSave = other.gameObject.transform; 
        }
        if(other.collider.tag == "enemy")
        {
            this.transform.position = lastSave.position;
        }
        if(other.collider.tag == "sal")
        {
            sal++; 
            print("Sal Coletado: " + sal); 
            Destroy(other.gameObject);
        }
    }
}
