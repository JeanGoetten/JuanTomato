using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oreganoSpawner : MonoBehaviour
{
   [Range(0.1f, 5f)] public float Interval = 1f; 
    public GameObject oregano; 
    Vector3 positionRandom; 
    void Start() {
        StartCoroutine(CDShootInterval());
    }
    IEnumerator CDShootInterval(){
        while(true){
            yield return new WaitForSeconds(Interval); 
            int rand = Random.Range(-5, 5);
            positionRandom = new Vector3(rand, transform.position.y, transform.position.z); 
            Instantiate(oregano, positionRandom, transform.rotation); 
        }
    }
}
