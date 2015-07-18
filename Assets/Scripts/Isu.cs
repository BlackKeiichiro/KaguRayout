using UnityEngine;
using System.Collections;

public class Isu : Kagu{
	// Use this for initialization
	override protected void Start () {
		kagu_name = "isu";
		objectsizey = this.transform.localScale.y/this.transform.localScale.y;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
