using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Change_Script : MonoBehaviour {
	public Sprite cat_image;
	public Sprite fish_image;
	public Sprite wait_image;

	public Transform player;
	int creature_index;
	bool waiting;
	// Use this for initialization
	void Start () {
		GetComponent<Image> ().overrideSprite = fish_image;
		creature_index = 1;
		waiting = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			change_creature();
		}
	}

	public void change_creature(){
		if (!waiting) {
			player.GetComponent<player_script> ().change_creature (creature_index);
			if(creature_index==1){
				creature_index=0;
			}else{
				creature_index=1;
			}
			waiting=true;
			GetComponent<Image> ().overrideSprite = wait_image;
			Invoke("restart",1f);
		}
	}

	void restart(){
		if (creature_index == 0) {
			GetComponent<Image> ().overrideSprite = cat_image;
		} else {
			GetComponent<Image> ().overrideSprite = fish_image;
		}
		waiting = false;
	}
}
