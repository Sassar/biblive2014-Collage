using UnityEngine;
using System.Collections;

public class HeatMap : MonoBehaviour {

	private GameObject A1;
	//public string shelfs[50] ={A1, A3, A4, A5};

	// Use this for initialization
	void Start () {
		A1 = GameObject.Find ("A1");
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		GUI.backgroundColor = Color.yellow;
		GUI.Button(new Rect(10, 10, 70, 30), "A button");
	}
}