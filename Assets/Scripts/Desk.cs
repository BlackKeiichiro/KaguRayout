using UnityEngine;
using System.Collections;

public class Desk : Kagu {

	// Use this for initialization
	override protected void Start () {
		kagu_name = "desk";
		sizey = this.transform.localScale.y/100;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
