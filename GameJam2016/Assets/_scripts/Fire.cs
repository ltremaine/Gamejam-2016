using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	void OnMouseDown()
    {
        Debug.Log("Fire");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
	
	}
}
