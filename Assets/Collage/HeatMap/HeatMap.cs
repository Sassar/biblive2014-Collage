using UnityEngine;
using System.Collections;

public class HeatMap : MonoBehaviour {

	private GameObject A3;
	//public string shelfs[50] ={A3, A4, A5};
	private float alpha = 1.0f;
	private float G_A3 = 0.0f;
	private float B_A3 = 1.0f;
	Color color_A3;
	string movieName_A3;
	MovieTexture mov_A3;

	// Use this for initialization
	void Start () {
		// mov_A3 = Assets/Resources/A03/.renderer.materials.mainTexture;
		movieName_A3 = "b1012045";

		//G_A3 = .duaration % hogeeee;
		A3 = GameObject.Find ("A3");
		A3.renderer.material.color = new Color (1.0f, G_A3, B_A3, alpha);
	}
	
	// Update is called once per frame
	void Update () {
	}
}