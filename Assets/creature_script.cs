using UnityEngine;
using System.Collections;

public class creature_script : MonoBehaviour {
	public float base_speed;
	public string good_tag;
	string current_tag;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D info = Physics2D.Raycast (
			(Vector2)transform.position+new Vector2 (1f, -0.25f),
			-Vector2.up,
			10f);
		Debug.DrawRay ((Vector2)transform.position+new Vector2 (1f, -0.25f),
		              -Vector2.up);
		string floor_tag = "";
		if (info.collider != null) {
			floor_tag=info.collider.tag;
			current_tag = info.collider.tag;
		} 

	}

	public float get_current_speed(){
		if (current_tag == good_tag) {
			return base_speed;
		} else {
			return base_speed*0.1f;
		}
	}

	public string get_current_tag(){
		return current_tag;
	}
}
