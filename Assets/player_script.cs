using UnityEngine;
using System.Collections;

public class player_script : MonoBehaviour {
	public Transform creature;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		float speed = get_current_speed ();
		transform.Translate (-Vector2.left * speed * Time.fixedDeltaTime);
	}

	public float get_current_speed(){
		return creature.GetComponent<creature_script> ().get_current_speed();
	}
}
