using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score_Script : MonoBehaviour {
	public int score=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text> ().text = score.ToString();
	}
}
