using UnityEngine;
using System.Collections;

public class ClickWepon : MonoBehaviour {

    WeaponChange weponchange;

    void Start()
    {
        weponchange = GameObject.Find("Canvas").GetComponent<WeaponChange>();
    }

    void Update()
    {
    }

    public void click()
    {
        if (gameObject.name == "Bomb")
        {
            Debug.Log("Clicked.Bomb");
            weponchange.SetWepon2();
        }

        if (gameObject.name == "Syuriken")
        {
            Debug.Log("Clicked.Syuriken");
            weponchange.SetWepon1();
        }
    }



}
