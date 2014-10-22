using UnityEngine;
using System.Collections;

public class FPC : MonoBehaviour {
	public float walkSpeed = 7.0f; //歩く速度
	public float gravity = 10.0f;//重力加速度
	private Vector3 velocity;//現在の速度
	
	private float RotSpeed = 90.0f; //回転速度係数
	private float LimitRotX = 50f; //回転可能限界
	
	private CharacterController controller;
	
	void Start () {
		
		controller = GetComponent<CharacterController>();
		
	}
	
	void OnGUI() {
		
		velocity = Vector3.zero;
		
		if (Input.GetKey(KeyCode.A)){
			velocity -= transform.right;
		}
		else if (Input.GetKey(KeyCode.D)){
			velocity += transform.right;
		}
		if (Input.GetKey(KeyCode.W)){
			velocity += transform.forward;
		}
		else if (Input.GetKey(KeyCode.S)){
			velocity -= transform.forward;
		}
		
		if(GUI.RepeatButton(new Rect(140,275,40,20), "前")) {
			velocity += transform.forward;
		}
		if(GUI.RepeatButton(new Rect(140,325,40,20), "後")) {
			velocity -= transform.forward;
		}
		if(GUI.RepeatButton(new Rect(165,300,40,20), "右")) {
			velocity += transform.right;
		}
		if(GUI.RepeatButton(new Rect(115, 300,40,20), "左")) {
			velocity -= transform.right;
		}
		
		
		velocity *= walkSpeed;
		
		velocity.y = -gravity;//重力設定
		
		controller.Move(velocity * Time.deltaTime);
	}
	
	void PlayerRotation(){
		
		float RotX = 0f , RotY = 0f;
		
		if (Input.GetKey(KeyCode.LeftArrow)){
			RotY = -1f;
		}
		else if (Input.GetKey(KeyCode.RightArrow)){
			RotY = 1f;
		}
		if (Input.GetKey(KeyCode.UpArrow)){
			RotX = -1f;
		}
		else if (Input.GetKey(KeyCode.DownArrow)){
			RotX = 1f;
		}
		
		if(Input.touchCount > 0){
			foreach ( Touch touch in Input.touches ){
				RotX = -touch.deltaPosition.y;
				RotY = touch.deltaPosition.x;	
			}
		}
		
		float NextRotX = transform.eulerAngles.x + RotX * RotSpeed *Time.deltaTime;
		
		if(NextRotX > LimitRotX && NextRotX < 360f - LimitRotX){
			NextRotX = NextRotX > 180f ? 360f - LimitRotX : LimitRotX;
		}
		
		transform.rotation = Quaternion.Euler( 
		                                      NextRotX, 
		                                      transform.eulerAngles.y + RotY * RotSpeed *Time.deltaTime ,
		                                      transform.eulerAngles.z
		                                      ) ;
	}
	
	void Update () {
		PlayerRotation();
		//OnGUI();
	}
	
}
