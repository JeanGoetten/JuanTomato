using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class explosionController : MonoBehaviour
{
    AudioSource audioData;
    private void Start() {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }
    void Update()
    {
        Destroy(gameObject, 0.3f);
    }
}
