using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetSwap : MonoBehaviour
{
    [SerializeField]
    private GameObject HamperSheet;

    [SerializeField] 
    private AudioSource sheetAudio;

    [SerializeField]
    private GameObject BloodySheet;

    public void InspectSheet() {
        HamperSheet.SetActive(false);
        sheetAudio.Play();
        BloodySheet.SetActive(true);
    }
}
