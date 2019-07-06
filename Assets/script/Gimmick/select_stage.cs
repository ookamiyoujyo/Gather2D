using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class select_stage : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject gamemanager, fadeImageobject;
    float fadeSpeed = 0.01f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    float red, green, blue, alfa;
    public Image fadeImage; //白いパネル
    public static int RTA;
    public static float timer;
    int selectstage = 0;

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
    public void stage1()
    {
        RTA = 0;
        selectstage = 1;
        StartCoroutine(fadeout());
    }
    public void stage2()
    {
        RTA = 0;
        selectstage = 2;
        StartCoroutine(fadeout());
    }
    public void stage3()
    {
        RTA = 0;
        selectstage = 3;
        StartCoroutine(fadeout());
    }
    public void stage4()
    {
        RTA = 0;
        selectstage = 4;
        StartCoroutine(fadeout());
    }
    public void stage5()
    {
        RTA = 0;
        selectstage = 5;
        StartCoroutine(fadeout());
    }
    public void stage6()
    {
        RTA = 0;
        selectstage = 6;
        StartCoroutine(fadeout());
    }
    public void stage7()
    {
        RTA = 0;
        selectstage = 7;
        StartCoroutine(fadeout());
    }
    public void stage8()
    {
        RTA = 0;
        selectstage = 8;
        StartCoroutine(fadeout());
    }
    public void stage9()
    {
        RTA = 0;
        selectstage = 9;
        StartCoroutine(fadeout());
    }
    public void stage10()
    {
        RTA = 0;
        selectstage = 10;
        StartCoroutine(fadeout());
    }
    public void stageRTA()
    {
        RTA = 1;
        timer = 0f;
        selectstage = 1;
        StartCoroutine(fadeout());
    }
    IEnumerator fadeout()   //④フェードアウトコルーチン
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        gamemanager.GetComponent<button_ON>().switchOFF();
        fadeImageobject.SetActive(true);
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
    public static int RTAflag()//通常モード判断フラグ確認用
    {
        return RTA;
    }
    public static float Timer()//裏モード判断フラグ確認用
    {
        return timer;
    }
}
