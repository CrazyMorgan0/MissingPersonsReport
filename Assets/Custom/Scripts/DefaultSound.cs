using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultSound : MonoBehaviour
{
    [SerializeField]
    private AudioSource defaultSound;

    public void Play() {
        defaultSound.Play();
    }
}
