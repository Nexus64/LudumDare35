using UnityEngine;
using System.Collections;

public class Camera_Script : MonoBehaviour {
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate(){
		float speed=player.GetComponent<player_script> ().get_current_speed();
		transform.Translate (-Vector2.left * speed * Time.fixedDeltaTime);
	}
}
