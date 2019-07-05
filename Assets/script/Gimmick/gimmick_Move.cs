using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmick_Move : MonoBehaviour
{
    public GameObject Move_Object;
    public float Move_Time = 5f,Move_Speed_X = 1f, Move_Speed_Y = 1f;
    float Set_Move_Time;

    void Start()
    {
        StartCoroutine(Move_Plus());
    }

    IEnumerator Move_Plus()
    {
        Set_Move_Time = Move_Time;
        while (Gimmick_Move_Plus())
        {
            yield return null;
        }
    }
    bool Gimmick_Move_Plus()
    {
        Set_Move_Time -= Time.deltaTime;
        Move_Object.transform.position += Move_Object.transform.right * Move_Speed_X * Time.deltaTime;
        Move_Object.transform.position += Move_Object.transform.up * Move_Speed_Y * Time.deltaTime;
        if (Set_Move_Time <= 0.0)
        {
            StartCoroutine(Move_Minus());
            return false;
        }
        return true;
    }


    IEnumerator Move_Minus()
    {
        Set_Move_Time = Move_Time;
        while (Gimmick_Move_Minus())
        {
            yield return null;
        }
    }
    bool Gimmick_Move_Minus()
    {
        Set_Move_Time -= Time.deltaTime;
        Move_Object.transform.position -= Move_Object.transform.right * Move_Speed_X * Time.deltaTime;
        Move_Object.transform.position -= Move_Object.transform.up * Move_Speed_Y * Time.deltaTime;
        if (Set_Move_Time <= 0.0)
        {
            StartCoroutine(Move_Plus());
            return false;
        }
        return true;
    }
}
