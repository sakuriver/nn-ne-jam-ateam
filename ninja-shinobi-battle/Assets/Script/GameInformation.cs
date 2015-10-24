using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	public static int WEAPON_CODE_SHURIKEN = 0;
	public static int WEAPON_CODE_BOMB = 1;
	public AudioClip selectAudioClip;

	public int selectWeapon = 0;
	public int enemyCreateCount = 0;

	private AudioSource audioSource; 

	void Start() {

		audioSource = GameObject.Find ("SceneManager").GetComponent<AudioSource> ();
		audioSource.clip = selectAudioClip;

		for (int i = 0; i < 5; i++) {
			// プレハブを取得
			GameObject prefab;
			if (Random.value * 5 > 2) {
				prefab = (GameObject)Resources.Load ("Prefab/Friend1");
			} else {
				prefab = (GameObject)Resources.Load ("Prefab/Friend2");
			} 
			Vector3 position = new Vector3 ((Random.value * 8) - (Random.value * 8), (Random.value * 4) - (Random.value * 4), 10);
			// プレハブからインスタンスを生成
			Instantiate (prefab, position, Quaternion.identity);
		}
	}
	
	public void Update() {
		if (enemyCreateCount > 70) {
			// プレハブを取得
			GameObject prefab = (GameObject)Resources.Load ("Prefab/Enemy");
			Vector3 position = new Vector3 ((Random.value * 8) - (Random.value * 8), (Random.value * 4) - (Random.value * 4), -10);
			// プレハブからインスタンスを生成
			Instantiate (prefab, position, Quaternion.identity);
			enemyCreateCount=0;
		}

		if (Input.GetMouseButton (0)) {
			SelectClipPlay();
			if (this.selectWeapon == GameInformation.WEAPON_CODE_SHURIKEN) {

			} else {

			}
		}
		//GameObject.Find ("EnmyNumber").GetComponent<GUIText> ().text = GameObject.FindGameObjectsWithTag("enemy").Length.ToString();	
		enemyCreateCount++;
	}

	public void SelectClipPlay() {
		audioSource.Play();
	}

}
