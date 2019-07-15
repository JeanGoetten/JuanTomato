using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject spawnPoint; 
    public int life = 100; 
    private int sal = 0; 
    private void OnCollisionEnter2D(Collision2D other){
        if(other.collider.tag == "enemy")
        {
            life--; 
            this.transform.position = spawnPoint.transform.position;
        }
        if(other.collider.tag == "sal")
        {
            sal++; 
            print("Sal Coletado: " + sal); 
            Destroy(other.gameObject);
        }    
    }
}
