using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRoom : MonoBehaviour
{
    [SerializeField]
    private GameObject XR;
    public GameObject player;
    private Dialogue dialogue;

    [SerializeField]
    private GameObject CheckpointBedroom;
    [SerializeField]
    private GameObject CheckpointBathroom;
    [SerializeField]
    private GameObject CheckpointHallway;
    [SerializeField]
    private GameObject CheckpointBlackroom;

    public void TeleportToBedroom() {
        XR.transform.position = CheckpointBedroom.transform.position;
    }

    public void TeleportToBathroom() {
        XR.transform.position = CheckpointBathroom.transform.position;
    }

    public void TeleportToHallway() {
        XR.transform.position = CheckpointHallway.transform.position;
    }

    public void TeleportToBlackroom() {
        XR.transform.position = CheckpointBlackroom.transform.position;
    }

    IEnumerator Intro() {
        TeleportToBlackroom();
        dialogue.PoliceRead();
        yield return new WaitForSeconds(100f);
        TeleportToHallway();
        dialogue.HelloJones();
    }

    void Start() {
        dialogue = player.GetComponent<Dialogue>();
        //StartCoroutine(Intro());
        //Skip intro
        TeleportToHallway();
    }

}
