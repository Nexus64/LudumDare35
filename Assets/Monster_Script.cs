using UnityEngine;
using System.Collections;

public class Monster_Script : MonoBehaviour {
	public Transform player;
	public Transform dead_prefab;
	public Transform game_over;
	public Transform buttons;
	bool gameover=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float playerspeed=player.GetComponent<player_script> ().get_base_speed();
		float speed = playerspeed;
		if (player.position.x-transform.position.x<8){
			speed*=0.75f;
		}
		if(transform.position.x-player.position.x>10){
			speed=0;
		}
		if (player.position.x < transform.position.x && !gameover) {

			kill_player();
		}

		transform.Translate (-Vector2.left * speed * Time.fixedDeltaTime);

	}

	void kill_player(){
		Destroy (player.GetComponent<player_script> ().creature.gameObject);
		player.GetComponent<player_script> ().creature = Instantiate (dead_prefab);
		game_over.gameObject.SetActive (true);
		Destroy (buttons.gameObject);
		gameover = true;
	}
}
