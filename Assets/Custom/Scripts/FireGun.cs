using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject player;
    private bool safetyTrigger = false;
    [SerializeField]
    private AudioSource gunAudioSource;

    [SerializeField]
    private GameObject flash;
    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private Animator FlashAnimator;

    public void FireBullet() {
        Debug.Log("Fire");
        gunAudioSource.Play();
        FlashAnimator.ResetTrigger("Fire");
        FlashAnimator.SetTrigger("Fire");
    }

    public void Trigger() {
        if(!safetyTrigger) {
            FireBullet();
            int suspectLayer = 1 << 6;
            if(Physics.Raycast(
                bullet.transform.position, 
                bullet.transform.TransformDirection(Vector3.forward), 
                Mathf.Infinity, 
                suspectLayer
            )) {
                Debug.Log("HIT");
                player.GetComponent<TeleportRoom>().TeleportToBlackroom();
                Debug.Log("Miss");
                Debug.DrawRay(
                    bullet.transform.position, 
                    bullet.transform.TransformDirection(Vector3.forward) * 1000, Color.red
                ); 
            }
        }
    }
}
