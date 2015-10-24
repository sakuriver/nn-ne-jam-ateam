using UnityEngine;
using System.Collections;

public class BombButtonScript : MonoBehaviour {
	
	public void selectBomb() {
		GameObject.Find("SceneManager").GetComponent<GameInformation>().selectWeapon = GameInformation.WEAPON_CODE_BOMB;
	}
	
}
