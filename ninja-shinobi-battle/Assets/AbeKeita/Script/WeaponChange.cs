using UnityEngine;
using System.Collections;

public class WeaponChange : MonoBehaviour {

    // 手持ち武器(1:手裏剣2:爆弾)
    private int wepon_Hand = 1;

    public GameObject check;

	// Use this for initialization
	void Start () {
        check.transform.position = GameObject.Find("Syuriken").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        // デバッグ用　スペースキーで現在装備している武器が表示
        if (Input.GetButtonDown("Jump"))
        {
            if (wepon_Hand == 1)
            {
                Debug.Log("手裏剣");
            }
            if (wepon_Hand == 2)
            {
                Debug.Log("爆弾");
            }
        }
	}

    public void SetWepon1()
    {
        wepon_Hand = 1;
        check.transform.position = GameObject.Find("Syuriken").transform.position;
    }

    public void SetWepon2()
    {
        wepon_Hand = 2;
        check.transform.position = GameObject.Find("Bomb").transform.position;
    }

}
