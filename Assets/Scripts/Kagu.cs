using UnityEngine;
using System.Collections;

abstract public class Kagu : MonoBehaviour {
	protected void Awake(){
		nowposition = this.transform.position;
		stage = GameObject.Find("Stage") as GameObject;
		manager = GameObject.Find("Manager").GetComponent<Manager>();
	}
	protected void OnMouseDown(){
		manager.nowObject = this.gameObject;
		lock_flag = false;
		mouse_position =  Camera.main.WorldToScreenPoint(transform.position);
		save_position = this.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouse_position.z));
		
	}
	protected void OnMouseDrag(){
		lock_flag = false;
		Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouse_position.z);
		Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + save_position;
		this.transform.position = currentPosition;
		if(this.transform.position.y < stage.transform.position.y){
			Vector3 localposition = this.transform.position;
			localposition.y = stage.transform.position.y + objectsizey;
			this.transform.position = localposition;
		}
	}
	protected void KaguAttach(){
		if(Physics.Raycast(this.transform.position,Vector3.down,out _raycasthit,15) && !lock_flag){
			if(_raycasthit.transform.gameObject.tag == "Attach"){
				Vector3 attach_position = _raycasthit.transform.position;
				attach_position.y += objectsizey * 5;
				nowposition = attach_position;
				lock_flag = true;
			}
		}	
		if(lock_flag)
			this.transform.position = nowposition;
	}
	
	protected void KaguRotation(){
		if(Input.GetKey(KeyCode.R) && this.gameObject.name == manager.nowObject.name){
			this.transform.RotateAround(this.transform.position,transform.up,10);
		}
	}
	public string getKaguName(){
		return this.kagu_name;
	}
	
	abstract protected void Start ();
	abstract protected void Update ();
	private Vector3 mouse_position;
	private Vector3 save_position;
	private RaycastHit _raycasthit;
	private Manager manager;
	private GameObject stage;
	protected Vector3 nowposition;
	protected bool lock_flag = false;
	protected string kagu_name;
	protected float objectsizey;
}
