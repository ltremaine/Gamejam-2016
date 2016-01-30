using UnityEngine;
using System.Collections;

public class waterEffect : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log ("Water");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }

}
