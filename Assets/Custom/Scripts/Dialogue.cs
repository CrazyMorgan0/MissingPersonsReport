using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public AudioClip policeRead;

    //Mac
    public AudioClip jones;
    public AudioClip noCraftKnife;

    //Jones
    public AudioClip lounge;
    public AudioClip locked;
    private bool playKey = true;
    public AudioClip key;
    public AudioClip bathroom;
    public AudioClip sheets;
    public AudioClip xanax;
    public AudioClip craftKnife;
    public AudioClip inhale;
    public AudioClip gunReady;
    public AudioClip kate;

    [SerializeField]
    private AudioSource playerAudioSource;

    public void PoliceRead() {
        playerAudioSource.PlayOneShot(policeRead);
    }

    public void HelloJones() {
        playerAudioSource.PlayOneShot(jones);
    }

    public void Lounge() {
        playerAudioSource.PlayOneShot(lounge);
    }

    public void Locked() {
        playerAudioSource.PlayOneShot(locked);
    }

    public void Key() {
        if(playKey) {
            playerAudioSource.PlayOneShot(key);
            playKey = false;
        }
    }

    public void Bathroom() {
        playerAudioSource.PlayOneShot(bathroom);
    }

    public void Sheets() {
        playerAudioSource.PlayOneShot(sheets);
    }

    public void Xanax() {
        playerAudioSource.PlayOneShot(xanax);
    }

    public void CraftKnife() {
        playerAudioSource.PlayOneShot(craftKnife);
    }

    public void NoCraftKnife() {
        playerAudioSource.PlayOneShot(noCraftKnife);
    }

    public void Inhale() {
        playerAudioSource.PlayOneShot(inhale);
    }

    public void GunReady() {
        playerAudioSource.PlayOneShot(gunReady);
    }

    public void Kate() {
        playerAudioSource.PlayOneShot(kate);
    }
}
