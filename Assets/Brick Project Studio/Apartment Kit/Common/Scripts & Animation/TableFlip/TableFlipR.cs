using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableFlipR: MonoBehaviour {

	public Animator FlipR;
	public bool open;
	public Transform Player;

	void Start (){
		open = false;
	}

	public void Toggle() {
		if(open) {
			StartCoroutine(closing());
		}
		else {
			StartCoroutine(opening());
		}
	}

	IEnumerator opening(){
		print ("you are opening the door");
        FlipR.Play ("Rup");
		open = true;
		yield return new WaitForSeconds (.5f);
	}

	IEnumerator closing(){
		print ("you are closing the door");
        FlipR.Play ("Rdown");
		open = false;
		yield return new WaitForSeconds (.5f);
	}


}

