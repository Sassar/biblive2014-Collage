using UnityEngine;
using System.Collections;

public class HM: MonoBehaviour {

	private float alpha = 1.0f;
	private float G = 0.0f;
	private float B = 1.0f;

	// This shelf name
	private string Shelf_Name;
	private MovieTexture mov_Texture;
	GameObject Main_Shelf;

	Color color_A3;
//	 scriptManager;

	// Use this for initialization
	void Start () {
		Shelf_Name = this.gameObject.name;
		Shelf_Name = Shelf_Name.Replace("_HM", "");
		Main_Shelf = GameObject.Find (Shelf_Name);

		mov_Texture = Main_Shelf.renderer.material.mainTexture as MovieTexture;
//		G = mov_Texture.duration % ;

//		scriptManager = GetComponent("managerrrrrrr");
//		game_OBJECT.renderer.material.color = new Color (1.0f, G, B, alpha);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
