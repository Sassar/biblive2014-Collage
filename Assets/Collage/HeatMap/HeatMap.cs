using UnityEngine;
using System.Collections;

public class HeatMap : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		GUI.backgroundColor = Color.yellow;
		GUI.Button(new Rect(10, 10, 70, 30), "A button");
	}
}