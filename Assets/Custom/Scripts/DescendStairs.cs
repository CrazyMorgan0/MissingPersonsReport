using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendStairs : MonoBehaviour
{
    public GameObject XR;
    public GameObject player;
    private Dialogue dialogue;

    [SerializeField]
    private GameObject leftDoor;
    [SerializeField]
    private GameObject rightDoor;
    [SerializeField]
    private Animator suspectAnimator;

    [SerializeField]
    private GameObject CheckpointBasement;

    void Start() {
        dialogue = player.GetComponent<Dialogue>();
    }

    IEnumerator Ending() {
        dialogue.Kate();
        yield return new WaitForSeconds(5);
        suspectAnimator.Play("ExitDoors");
        opencloseDoor leftScript = leftDoor.GetComponent<opencloseDoor>();
        opencloseDoor1 rightScript = rightDoor.GetComponent<opencloseDoor1>();
        leftScript.Toggle();
        rightScript.Toggle();
        
    }

    public void Descend() {
        XR.transform.position = CheckpointBasement.transform.position;
        XR.transform.rotation = CheckpointBasement.transform.rotation;
        StartCoroutine(Ending());
    }
}
