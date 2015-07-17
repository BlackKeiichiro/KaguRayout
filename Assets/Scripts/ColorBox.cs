using UnityEngine;
using System.Collections;

public class ColorBox : Kagu {

	// Use this for initialization
	override protected void Start () {
		kagu_name = "colorbox";
		sizey = this.transform.localScale.y/1000;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
