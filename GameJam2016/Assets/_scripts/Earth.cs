using UnityEngine;
using System.Collections;

public class Earth : MonoBehaviour 
{
    void OnMouseDown()
    {
        Debug.Log("Earth");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
	
}
