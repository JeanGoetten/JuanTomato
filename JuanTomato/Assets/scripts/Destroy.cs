using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [Range(1, 20)] public int time = 15; 
    void Start()
    {
        StartCoroutine(CDDestroy()); 
    }
    IEnumerator CDDestroy(){
        yield return new WaitForSeconds(time); 
        Destroy(gameObject); 
    }
}
