using UnityEngine;
using System.Collections;

public class ColorBox : Kagu {

	// Use this for initialization
	override protected void Start () {
		kagu_name = "colorbox";
		objectsizey = this.transform.localScale.y/this.transform.localScale.y*2.0f;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
