using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StageCounter : MonoBehaviour {

    private int stageNomber;

	// Use this for initialization
	void Start () {
        stageNomber = 1;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<Text>().text = "Stage : " + stageNomber;
	}

    void SetStage(int stagenom)
    {
        stageNomber = stagenom;
    }
}
