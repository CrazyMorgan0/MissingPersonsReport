using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer_Pull_NegX : MonoBehaviour
{

	public Animator pull_NegX;
	public bool open;
	public Transform Player;

	void Start()
	{
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

	IEnumerator opening()
	{
		print("you are opening the door");
		pull_NegX.Play("openpull_NegX");
		open = true;
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the door");
		pull_NegX.Play("closepush_NegX");
		open = false;
		yield return new WaitForSeconds(.5f);
	}
}