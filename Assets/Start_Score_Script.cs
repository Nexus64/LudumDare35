using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Start_Score_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int score =PlayerPrefs.GetInt ("score");
		GetComponent<Text> ().text = "High Score: " + score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
