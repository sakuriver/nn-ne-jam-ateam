﻿using UnityEngine;
using System.Collections;

public class ShurikenButtonScript : MonoBehaviour {

	public void selectShuriken() {
		GameObject.Find ("SceneManager").GetComponent<GameInformation> ().SelectClipPlay();
		GameObject.Find("SceneManager").GetComponent<GameInformation>().selectWeapon = GameInformation.WEAPON_CODE_SHURIKEN;
		GameObject.Find("Check").transform.position = GameObject.Find("WeaponShuriken").transform.position;
	}

}
