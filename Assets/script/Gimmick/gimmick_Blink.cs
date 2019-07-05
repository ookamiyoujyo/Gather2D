using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmick_Blink : MonoBehaviour
{
    public GameObject Blink_Object_Set_Collider;
    public float Blink_Time = 3f;
    float Set_Blink_Time;

    void Start()
    {
        StartCoroutine(Blink_OFF());
    }

    IEnumerator Blink_ON()
    {
        Set_Blink_Time = Blink_Time;
        while (Gimmick_Blink_ON())
        {
            yield return null;
        }
    }
    bool Gimmick_Blink_ON()
    {
        Set_Blink_Time -= Time.deltaTime;
        if (Set_Blink_Time <= 0.0)
        {
            Blink_Object_Set_Collider.SetActive(true);
            StartCoroutine(Blink_OFF());
            return false;
        }
        return true;
    }


    IEnumerator Blink_OFF()
    {
        Set_Blink_Time = Blink_Time;
        while (Gimmick_Blink_OFF())
        {
            yield return null;
        }
    }
    bool Gimmick_Blink_OFF()
    {
        Set_Blink_Time -= Time.deltaTime;
        if (Set_Blink_Time <= 0.0)
        {
            Blink_Object_Set_Collider.SetActive(false);
            StartCoroutine(Blink_ON());
            return false;
        }
        return true;
    }
}
