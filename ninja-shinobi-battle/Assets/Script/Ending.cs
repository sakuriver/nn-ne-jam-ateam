using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Ending : MonoBehaviour {

    GameObject Fade;    //フェードに使うGameObject
    bool FadeInFlg;     //フェードインに使うフラグ
    bool FadeOutFlg;    //フェードアウトに使うフラグ
    float StoryTime;
    GameObject gStory;
    GameObject StartButton;
    //GameObject TitleRogo;
    //初期化
    void Start()
    {
        StartButton = GameObject.Find("ModoruButton");
        StartButton.SetActive(false);
     // TitleRogo = GameObject.Find("TitleRogo");
     // TitleRogo.SetActive(false);
        Fade = GameObject.Find("Fade");
        gStory = GameObject.Find("Story");
        FadeInFlg = true;
        FadeOutFlg = false;
    }
    //アップデート
    void Update()
    {
        Story();
        FadeIn();
        if (FadeOutFlg)
        {
            SceneChange();
        }

    }
    //FadeIn
    void FadeIn()
    {
        //フェードインさせる
        if (FadeInFlg)
        {
            Fade.GetComponent<Image>().color += new Color(0.0f, 0.0f, 0.0f, -0.001f);
        }
        //alphaが0になったら止める
        if (Fade.GetComponent<Image>().color.a <= 0.1f)
        {
            FadeInFlg = false;
        }
    }
    //ステージ切り替え
    public void SceneChange()
    {
        FadeOutFlg = true;
        //フェードアウトしてシーンを切り替える
        Fade.GetComponent<Image>().color += new Color(0.0f, 0.0f, 0.0f, 0.01f);
        if (Fade.GetComponent<Image>().color.a >= 0.9f)
        {
            Application.LoadLevel("OpeningScene");
        }
    }
    //ストーリー関連
    void Story()
    {
        StoryTime += Time.deltaTime;
        if (StoryTime >= 22.0f)
        {
            gStory.SetActive(false);
            StartButton.SetActive(true);
            //TitleRogo.SetActive(true);
        }
    }
}

