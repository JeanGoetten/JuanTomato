using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class almondegaSpawner : MonoBehaviour
{

    [Range(5, 50)] public float Interval; 
    public GameObject almondega; 
    void Start() {
        StartCoroutine(CDShootInterval());
    }
    IEnumerator CDShootInterval(){
        while(true){
            yield return new WaitForSeconds(Interval); 
            Instantiate(almondega, transform.position, transform.rotation); 
        }
    }
}
