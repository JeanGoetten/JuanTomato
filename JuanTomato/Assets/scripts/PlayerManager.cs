using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerManager : MonoBehaviour
{
    public GameObject camera; 
    Transform lastSave; 
    private int sal = 0; 
    private void Start() {
        transform.position = new Vector3(0f, 0f, 0f); 

        DontDestroyOnLoad(this.gameObject); 
        DontDestroyOnLoad(camera); 
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
        if(other.collider.tag == "finish")
        {
            SceneManager.LoadScene("Fase2"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "finish2")
        {
            SceneManager.LoadScene("Fase3"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "finish3")
        {
            SceneManager.LoadScene("Fase4"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "finish4")
        {
            SceneManager.LoadScene("Fase5"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "finish5")
        {
            SceneManager.LoadScene("Fase6"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "finish6")
        {
            Destroy(camera); 
            SceneManager.LoadScene("Final"); 
            transform.position = new Vector3(0f, 0f, 0f); 
        }
        if(other.collider.tag == "final")
        {
            SceneManager.LoadScene("Menu"); 
            Destroy(this.gameObject);
        }
    }
}
