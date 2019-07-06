using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class title_start : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        StartCoroutine(fadein());
    }

    float fadeSpeed = 0.01f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    float red, green, blue, alfa;
    public Image fadeImage; //白いパネル
    public GameObject fade_Image, start_game_button;

    IEnumerator fadein()   //④フェードアウトコルーチン
    {
        while (StartFadeIn())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }
    bool StartFadeIn() //⑥コルーチンに呼び出される
    {
        alfa -= fadeSpeed;
        SetAlpha();
        if (alfa <= 0)  //⑨完全に不透明になったらループを抜ける
        {
            BGM.Play(0);
            fade_Image.SetActive(false);
            start_game_button.SetActive(true);
            BGM.Play(0);
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }


    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
