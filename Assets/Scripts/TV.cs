using UnityEngine;
using System.Collections;

public class TV : Kagu {
	override protected void Start () {
		kagu_name = "TV";
		objectsizey = 0;
	}
	
	// Update is called once per frame
	override protected void Update () {
		KaguAttach();
		KaguRotation();
	}
}
