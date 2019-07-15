using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paliteiraController : MonoBehaviour
{
    [Range(0, 10)] public float shootInterval; 
    public GameObject palito; 
    Animator anim; 
    void Start() {
        anim = GetComponent<Animator>(); 
        StartCoroutine(CDShootInterval());
    }
    IEnumerator CDShootInterval(){
        while(true){
            yield return new WaitForSeconds(shootInterval); 
            Instantiate(palito, transform.position, transform.rotation); 
        }
    }
}
