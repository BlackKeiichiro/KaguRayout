using UnityEngine;
using System.Collections;

public class Desk : Kagu {
	override protected void Start () {
		kagu_name = "desk";
		objectsizey = this.transform.localScale.y/this.transform.localScale.y*2.8f;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
