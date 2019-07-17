using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oreganoController : MonoBehaviour
{
   
    [Range(0f, 10f)] public float speed = 1f; 
    [Range(0f, 10f)] public float LifeTime = 5f; 
    private void Update() {
        transform.Translate((Vector3.down * Time.deltaTime)*speed);
        Destroy(gameObject, LifeTime); 
    }
}
