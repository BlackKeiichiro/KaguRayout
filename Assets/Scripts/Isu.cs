using UnityEngine;
using System.Collections;

public class Isu : Kagu{
	// Use this for initialization
	override protected void Start () {
		kagu_name = "isu";
		sizey = this.transform.localScale.y/100;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
