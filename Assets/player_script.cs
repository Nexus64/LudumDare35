using UnityEngine;
using System.Collections;

public class player_script : MonoBehaviour {
	public Transform creature;
	public Transform cat_prefab;
	public Transform fish_prefab;
	public Transform score;
	string place="ground";
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (creature.GetComponent<creature_script> ().get_current_tag () != place) {
			switch (creature.GetComponent<creature_script> ().get_current_tag ()){
			case "ground":
				transform.position=new Vector2(transform.position.x, 0f);
				break;
			case "water":
				transform.position=new Vector2(transform.position.x, -
				                               +0.5f);
				break;
			}
			place=creature.GetComponent<creature_script> ().get_current_tag ();
		}
		score.GetComponent<Score_Script> ().score = (int)transform.position.x * 10;
	}

	void FixedUpdate(){
		float speed = get_current_speed ();
		transform.Translate (-Vector2.left * speed * Time.fixedDeltaTime);
	}

	public float get_current_speed(){
		return creature.GetComponent<creature_script> ().get_current_speed();
	}
	public float get_base_speed(){
		return creature.GetComponent<creature_script> ().base_speed;
	}

	public void change_creature(int creature_index){
		Destroy (creature.gameObject);
		if (creature_index == 0) {
			creature=Instantiate(cat_prefab);
		} else {
			creature=Instantiate(fish_prefab);
		}
		creature.position = transform.position;
		creature.parent = transform;
	}
}
