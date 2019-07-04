using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class gameend : MonoBehaviour
{
    public int selectstage;

    float fadeSpeed = 0.01f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    float red, green, blue, alfa;
    public Image fadeImage; //白いパネル
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
            SceneManager.LoadScene("title");
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }

    void SetAlpha1()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
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
}
