using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class button_ON : MonoBehaviour
{
    float fadeSpeed = 0.025f;
    public GameObject start_button;
    public GameObject[] start_game_button;
    public SpriteRenderer[] start_game_button_Image; 
    public TextMeshProUGUI　title_text1, title_text2;
    int date;
    float title_text_alfa = 255f, button_alfa = 0f;
    float red, green, blue;
    float red1, green1, blue1;

    void Start()
    {
        red = title_text1.color.r;
        green = title_text1.color.g;
        blue = title_text1.color.b;
        title_text_alfa = title_text1.color.a;

        red1 = title_text2.color.r;
        green1 = title_text2.color.g;
        blue1 = title_text2.color.b;
        date = PlayerPrefs.GetInt("cleardata", 0);
    }

    public void button_start()
    {
        start_button.SetActive(false);
        StartCoroutine(fadein());
    }

    void titleSetAlpha()
    {
        title_text1.color = new Color(red, green, blue, title_text_alfa);
        title_text2.color = new Color(red1, green1, blue1, title_text_alfa);
    }
    void buttonSetAlpha()
    {
        if (date >= 0)
        {
            start_game_button_Image[0].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 1)
        {
            start_game_button_Image[1].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 2)
        {
            start_game_button_Image[2].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 3)
        {
            start_game_button_Image[3].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 4)
        {
            start_game_button_Image[4].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 5)
        {
            start_game_button_Image[5].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 6)
        {
            start_game_button_Image[6].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 7)
        {
            start_game_button_Image[7].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 8)
        {
            start_game_button_Image[8].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 9)
        {
            start_game_button_Image[9].color = new Color(255, 255, 255, button_alfa);
        }
        if (date >= 10)
        {
            start_game_button_Image[10].color = new Color(255, 255, 255, button_alfa);
            start_game_button_Image[11].color = new Color(255, 255, 255, button_alfa);
            start_game_button_Image[12].color = new Color(255, 255, 255, button_alfa);
            start_game_button_Image[13].color = new Color(255, 255, 255, button_alfa);
            start_game_button_Image[14].color = new Color(255, 255, 255, button_alfa);
            start_game_button_Image[15].color = new Color(255, 255, 255, button_alfa);
        }
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

        button_alfa += fadeSpeed;
        buttonSetAlpha();
        if (button_alfa >= 1)  //⑨完全に不透明になったらループを抜ける
        {
            Debug.Log(date);
            if (date >= 0)
            {
                start_game_button[0].SetActive(true);
            }
            if (date >= 1)
            {
                start_game_button[1].SetActive(true);
            }
            if (date >= 2)
            {
                start_game_button[2].SetActive(true);
            }
            if (date >= 3)
            {
                start_game_button[3].SetActive(true);
            }
            if (date >= 4)
            {
                start_game_button[4].SetActive(true);
            }
            if (date >= 5)
            {
                start_game_button[5].SetActive(true);
            }
            if (date >= 6)
            {
                start_game_button[6].SetActive(true);
            }
            if (date >= 7)
            {
                start_game_button[7].SetActive(true);
            }
            if (date >= 8)
            {
                start_game_button[8].SetActive(true);
            }
            if (date >= 9)
            {
                start_game_button[9].SetActive(true);
            }
            if (date >= 10)
            {
                start_game_button[10].SetActive(true);
            }
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }


    //透明
    IEnumerator fadein()   //④フェードアウトコルーチン
    {
        while (StartFadeIn())  //⑤StartFadeOutからfalseが返ってくるまで実行
        {
            yield return null;  //⑫ループを１フレームの間止める
        }
    }
    bool StartFadeIn() //⑥コルーチンに呼び出される
    {
        title_text_alfa -= fadeSpeed;
        titleSetAlpha();
        if (title_text_alfa <= 0)  //⑨完全に不透明になったらループを抜ける
        {
            StartCoroutine(fadeout());
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }
    public void switchOFF()
    {
        start_game_button[0].SetActive(false);
        start_game_button[1].SetActive(false);
        start_game_button[2].SetActive(false);
        start_game_button[3].SetActive(false);
        start_game_button[4].SetActive(false);
        start_game_button[5].SetActive(false);
        start_game_button[6].SetActive(false);
        start_game_button[7].SetActive(false);
        start_game_button[8].SetActive(false);
        start_game_button[9].SetActive(false);
        start_game_button[10].SetActive(false);
    }

}
