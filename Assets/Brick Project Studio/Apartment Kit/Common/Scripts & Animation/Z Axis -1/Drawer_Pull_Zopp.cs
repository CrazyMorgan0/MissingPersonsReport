using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer_Pull_Zopp : MonoBehaviour
{

	public Animator pull;
	public bool open;
	public Transform Player;

	void Start()
	{
		open = false;
	}

	IEnumerator opening()
	{
		print("you are opening the door");
		pull.Play("openpullopp");
		open = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the door");
		pull.Play("closepushopp");
		open = false;
		yield return new WaitForSeconds(.5f);
	}

	public void Toggle() {
		if(open) {
			StartCoroutine(closing());
		}
		else {
			StartCoroutine(opening());
		}
	}
}