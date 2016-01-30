using UnityEngine;
using System.Collections;

public class Heal : MonoBehaviour
{
    void OnMouseDown()
    {
        Debug.Log("Heal");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }

}