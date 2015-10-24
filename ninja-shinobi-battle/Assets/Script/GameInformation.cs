using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	public static int WEAPON_CODE_SHURIKEN = 0;
	public static int WEAPON_CODE_BOMB = 1;

	public int selectWeapon = 0;
	public int enemyCreateCount = 0;
	void Start() {
	}

	public void Update() {
		if (enemyCreateCount > 70) {
			// プレハブを取得
			GameObject prefab = (GameObject)Resources.Load ("Prefab/Enemy");
			Vector3 position = new Vector3 ((Random.value * 8) - (Random.value * 8), (Random.value * 4) - (Random.value * 4), -10);
			// プレハブからインスタンスを生成
			Instantiate (prefab, position, Quaternion.identity);
			Debug.Log ("enemy create complete");
			enemyCreateCount=0;
		}
		enemyCreateCount++;
	}

}
