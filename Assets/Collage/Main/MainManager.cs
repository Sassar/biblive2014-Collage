using UnityEngine;
using System.Collections;

public class MainManager : MonoBehaviour {

	public float screenW;
	public float screenH;

	// Use this for initialization
	void Start () {
		screenW = Screen.width;
		screenH = Screen.height;
	}

	// Update is called once per frame
	void Update () {
		if (Application.platform == RuntimePlatform.Android && Input.GetKey(KeyCode.Escape)) {
			Application.LoadLevel(0);
		}
	}
	void OnGUI(){
		//TitleButton 
		if (GUI.Button (new Rect (screenW-55, 10, 50, 25), "Title")) {
			Application.LoadLevel(0);
		}
		//QuitButton
		/*
		if (GUI.Button (new Rect (screenW-screenW/10-5, 10, 50, 25), "Quit")) {
			Application.Quit ();
		}
		*/
	}
}