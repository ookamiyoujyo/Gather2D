using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class start_game : MonoBehaviour
{

    public TextMeshProUGUI text;
    private float timeleft;
    float red, green, blue, alfa;
    int flag = 0;
    private void Start()
    {
        red = text.color.r;
        green = text.color.g;
        blue = text.color.b;
        alfa = text.color.a;
    }

    void Update()
    {
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            timeleft = 0.5f;
            if(flag == 0)
            {
                text.color = new Color(red, green, blue, 255);
                flag = 1;
            }
            else
            {
                text.color = new Color(red, green, blue, 0);
                flag = 0;
            }
        }
    }
}
