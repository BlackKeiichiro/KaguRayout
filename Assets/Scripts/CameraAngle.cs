using UnityEngine;
using System.Collections;

public class CameraAngle : MonoBehaviour {
	// Use this for initialization
	void Start () {
		camera_flag = false;
		stage = GameObject.Find("Stage") as GameObject;
		_radian = Mathf.Abs(stage.transform.position.z - this.transform.position.z);
		angle = _horizontal = _vartical = 0;
		center = stage.transform.position;
		center.y += 20;
		CameraRotate(0);
	}
	
	// Update is called once per frame
	void Update () {
		_horizontal = Input.GetAxis("Horizontal");
		_vartical = Input.GetAxis("Vertical");
		transform.LookAt(GameObject.Find("Stage").transform);
		if(_horizontal != 0 && !camera_flag)
			CameraRotate(_horizontal);
		else if(Input.GetKeyDown(KeyCode.Space)){
			if(!camera_flag){
				save_position = this.transform.position;
				this.transform.position = new Vector3(0,130,0);
				camera_flag = true;
			}
			else if (camera_flag){
				camera_flag = false;
				this.transform.position = save_position;
				_vartical = 0;
			}
		}
	}
	
	void CameraRotate(float horizontal){
		radians = Vector3.right * _radian;
		angle += 100 * horizontal * Time.deltaTime % 360;
		rotate_position = Quaternion.AngleAxis(angle,Vector3.up) * radians;
		this.transform.position = rotate_position + center;
	}
	
	private float _horizontal;
	private float _vartical;
	private float angle;
	private float _radian;
	private bool camera_flag;
	private Vector3 radians;
	private Vector3 center;
	private Vector3 rotate_position;
	private Vector3 save_position;
	private Quaternion save_rotation;
	private GameObject stage;
}
