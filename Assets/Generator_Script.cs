using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator_Script : MonoBehaviour {
	public Transform water_prefab;
	public Transform ground_prefab;
	public Transform player;
	List<Transform> floor_list;
	int counter;
	float last_position;
	Transform floor_type;
	// Use this for initialization
	void Start () {
		float initial_position = player.position.x-6f*2.1f;
		Transform floor;
		floor_list=new List<Transform>();
		for (int i =0; i<20; i++) {
			floor=Instantiate(ground_prefab);
			floor.Translate(new Vector2(initial_position+i*2.1f,0));
			floor_list.Add(floor);
		}
		last_position = player.position.x;
		counter=15+(int)Mathf.Abs(Random.Range(0,10));
		floor_type = water_prefab;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.x - last_position > 2.1) {
			Transform floor=Instantiate(floor_type);
			float floor_position=Mathf.Floor((player.position.x+13*2.1f)/2.1f)*2.1f;
			floor.Translate(new Vector2(floor_position,0));
			floor_list.Add(floor);
			if (floor_list.Count>32){
				Transform old=floor_list[0];
				floor_list.RemoveAt(0);
				Destroy(old.gameObject);
			}
			last_position=Mathf.Floor(player.position.x/2.1f)*2.1f;
			float s=last_position+2.1f;
			counter-=1;
			if (counter<=0){
				if(floor_type==water_prefab){
					floor_type=ground_prefab;
				}else{
					floor_type=water_prefab;
				}
				counter=15+(int)Mathf.Abs(Random.Range(0,10));
			}
		}

	}
}
