using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    private bool locked = true;
    private bool open = false;
    private bool hasCraftHandle = false;
    private bool playInhale = true;
    
    [SerializeField]
    private Animator DoorAnimator;

    public GameObject player;

    private Dialogue dialogue;

    void Start() {
        dialogue = player.GetComponent<Dialogue>();
    }

	IEnumerator opening(){
		print("you are opening the door");
        DoorAnimator.Play("Door_Open");
		open = true;
		yield return new WaitForSeconds(2f);
        if(playInhale) {
            dialogue.Inhale();
            playInhale = false;
        }
	}

	IEnumerator closing(){
		print("you are closing the door");
        DoorAnimator.Play("Door_Close");
		open = false;
		yield return new WaitForSeconds(.5f);
	}

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Key")) {
            print("you unlocked the door");
            locked = false;
        }
    }

    public void SetCraftHandle(bool status) {
        hasCraftHandle = status;
    }

    public void Open() {
        if(open) {
            StartCoroutine(closing());
        } else {
            if(locked) {
                //Come back with key
                dialogue.Locked();
            } else {
                if(hasCraftHandle) {
                    StartCoroutine(opening());
                } else {
                    //Come back when craft knife handle has been found
                    dialogue.NoCraftKnife();
                }
            }
        }
    }
}
