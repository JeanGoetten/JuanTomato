using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class SkipController : MonoBehaviour
{
    public void SkipCinematica(){
        SceneManager.LoadScene("Fase1"); 
    }   
}