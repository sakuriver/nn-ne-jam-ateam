using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Nokori : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
       GetComponent<Text>().text = "残りShinobi : " + GameObject.FindGameObjectsWithTag("Shinobi").Length;
	
	}
}
