using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player_Move : MonoBehaviour
{
    public GameObject Main_Player, Player;
    public float speed = 5, Rotate_Speed = 50;
    static string control_Permission;
    public int clearcount;
    int count = 0; int clear_furagu = 0;
    public enum control
    {
        play,
        stop,
    }
    void Start()
    {
        clearcount *= 2;
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        control control = control.stop;
        control_Permission = control.ToString();

        StartCoroutine(fadein());
    }

    void Update()
    {

        if (control_Permission == "play")
        {
            if (Input.GetKey("up"))
            {
                Main_Player.transform.position += Main_Player.transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey("down"))
            {
                Main_Player.transform.position -= Main_Player.transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey("right"))
            {
                Main_Player.transform.position += Main_Player.transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey("left"))
            {
                Main_Player.transform.position -= Main_Player.transform.right * speed * Time.deltaTime;
            }
            Player.transform.Rotate(new Vector3(0, 0, Rotate_Speed) * Time.deltaTime, Space.World);
        }
    }
    public static void controoff()
    {
        control control = control.stop;
        control_Permission = control.ToString();
    }


    public void countnext()
    {
        count++;
        Debug.Log(count);
    }


    public GameObject text,GAMEOVERtext,clearbutton,overbutton;
    float effectspeed = 0.05f, speed1 = 0.01f, data = 0, data1 = 0;
    public void gameover()
    {
        if (clear_furagu == 0)
        {
            BGM.Stop();
            BGM.Play(2);
            overbutton.SetActive(true);
            GAMEOVERtext.SetActive(true);
        }
    }


    public  void effectstart()
    {
        if (count >= clearcount)
        {
            BGM.Stop();
            BGM.Play(1);
            clear_furagu = 1;
            controoff();
            clearbutton.SetActive(true);
            text.SetActive(true);
            StartCoroutine(gameclear());
        }
    }





    IEnumerator gameclear()
    {
        while (gameclearstart())
        {
            yield return null;
        }
    }
    bool gameclearstart()
    {
        if (data <= 1)
        {
            data += effectspeed;
            data1 += speed1;
            text.transform.localScale = new Vector3(data, data1, 1);
        }
        else
        {
            data1 += effectspeed;
            text.transform.localScale = new Vector3(1, data1, 1);
            if (data1 >= 1)
            {
                data = 0;
                data1 = 0;
                //button.SetActive(true);
                return false;
            }
        }
        return true;
    }






    float fadeSpeed = 0.01f;    //フェードスピード//白いパネルの透明度//カメラの前進スピード
    float red, green, blue, alfa;
    public Image fadeImage; //白いパネル

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
            control control = control.play;
            control_Permission = control.ToString();
            return false;   //⑭コルーチンのループを止める
        }
        return true;    //⑩コルーチンのループに戻る
    }


    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }

}
