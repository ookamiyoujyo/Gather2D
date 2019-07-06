using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class gameend : MonoBehaviour
{
    public int selectstage;

    float fadeSpeed = 0.01f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    float red, green, blue, alfa;
    public Image fadeImage; //白いパネル
    public TextMeshProUGUI timer_txst;
    public GameObject timer_txst_object;
    public static int RTA;
    public static float timer = 0;
    string floatfinish_Timer;
    public static　float floatfinish_Timer_tweet;
    void Update()
    {
        if (RTA == 1)
        {
            timer += Time.deltaTime;
            timer_txst.text = timer.ToString("F2"); 
        }
    }


    void Start()
    {
        RTA = select_stage.RTAflag(); 
        if (RTA == 1)
        {
            timer_txst_object.SetActive(true);
        }
    }
        void SetAlpha()
    {

        fadeImage.color = new Color(red, green, blue, alfa);
    }


    IEnumerator fadeout()   //④フェードアウトコルーチン
    {
        while (StartFadeOut())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }
    bool StartFadeOut() //⑥コルーチンに呼び出される
    {
        alfa += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)  //⑨完全に不透明になったらループを抜ける
        {
            if (selectstage == 1)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 1)
                {
                    PlayerPrefs.SetInt("cleardata", 1);
                }
            }
            if (selectstage == 2)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 2)
                {
                    PlayerPrefs.SetInt("cleardata", 2);
                }
            }
            if (selectstage == 3)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 3)
                {
                    PlayerPrefs.SetInt("cleardata", 3);
                }
            }
            if (selectstage == 4)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 4)
                {
                    PlayerPrefs.SetInt("cleardata", 4);
                }
            }
            if (selectstage == 5)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 5)
                {
                    PlayerPrefs.SetInt("cleardata", 5);
                }
            }
            if (selectstage == 6)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 6)
                {
                    PlayerPrefs.SetInt("cleardata", 6);
                }
            }
            if (selectstage == 7)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 7)
                {
                    PlayerPrefs.SetInt("cleardata", 7);
                }
            }
            if (selectstage == 8)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 8)
                {
                    PlayerPrefs.SetInt("cleardata", 8);
                }
            }
            if (selectstage == 9)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 9)
                {
                    PlayerPrefs.SetInt("cleardata", 9);
                }
            }
            if (selectstage == 10)
            {
                int deta;
                deta = PlayerPrefs.GetInt("cleardata", 0);
                if (deta < 10)
                {
                    PlayerPrefs.SetInt("cleardata", 10);
                }
            }
            RTA = select_stage.RTAflag();
            if (RTA == 0)
            {
                Debug.Log(RTA);
                SceneManager.LoadScene("title");
            }
            Debug.Log(RTA);
            selectstage += 1;
            if (RTA == 1)
            {
                if (selectstage == 2)
                {
                    SceneManager.LoadScene("stage2");
                }
                if (selectstage == 3)
                {
                    SceneManager.LoadScene("stage3");
                }
                if (selectstage == 4)
                {
                    SceneManager.LoadScene("stage4");
                }
                if (selectstage == 5)
                {
                    SceneManager.LoadScene("stage5");
                }
                if (selectstage == 6)
                {
                    SceneManager.LoadScene("stage6");
                }
                if (selectstage == 7)
                {
                    SceneManager.LoadScene("stage7");
                }
                if (selectstage == 8)
                {
                    SceneManager.LoadScene("stage8");
                }
                if (selectstage == 9)
                {
                    SceneManager.LoadScene("stage9");
                }
                if (selectstage == 10)
                {
                    SceneManager.LoadScene("stage10");
                }
                if (selectstage == 11)
                {
                    timer_txst_object.SetActive(false);
                    floatfinish_Timer = timer.ToString("F2");
                    floatfinish_Timer_tweet = timer;
                    float num = float.Parse(floatfinish_Timer);
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking(num);
                }
            }
       
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }

    IEnumerator fadeout1()   //④フェードアウトコルーチン
    {
        while (StartFadeOut1())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }
    bool StartFadeOut1() //⑥コルーチンに呼び出される
    {
        alfa += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)  //⑨完全に不透明になったらループを抜ける
        {
            if (selectstage == 1)
            {
                SceneManager.LoadScene("stage1");
            }
            if (selectstage == 2)
            {
                SceneManager.LoadScene("stage2");
            }
            if (selectstage == 3)
            {
                SceneManager.LoadScene("stage3");
            }
            if (selectstage == 4)
            {
                SceneManager.LoadScene("stage4");
            }
            if (selectstage == 5)
            {
                SceneManager.LoadScene("stage5");
            }
            if (selectstage == 6)
            {
                SceneManager.LoadScene("stage6");
            }
            if (selectstage == 7)
            {
                SceneManager.LoadScene("stage7");
            }
            if (selectstage == 8)
            {
                SceneManager.LoadScene("stage8");
            }
            if (selectstage == 9)
            {
                SceneManager.LoadScene("stage9");
            }
            if (selectstage == 10)
            {
                SceneManager.LoadScene("stage10");
            }
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }

    public void gameclea()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        StartCoroutine(fadeout());
    }
    public void over()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        StartCoroutine(fadeout1());
    }
    public void RTA_END()
    {
        timer = 0;
        SceneManager.LoadScene("title");
    }

    public void tweet()
    {
        string message = "私のクリアタイムは" + floatfinish_Timer_tweet.ToString("F2") + "秒！\n #アニマ～ルあつま～る ##unity1week\nhttps://unityroom.com/games/ookami_youjyo_animal_get_together";
        Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(message));
    }
}
