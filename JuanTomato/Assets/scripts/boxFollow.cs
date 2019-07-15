using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - player.transform.position;
    }
    void Update()
    {    
        Vector3 velocity = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position, player.transform.position + offset, ref velocity, 0.05f);
    
    }
}
