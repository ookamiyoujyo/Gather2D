using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RTA : MonoBehaviour
{
    public TextMeshProUGUI timer;
    float time = 0;
    void Update()
    {
        time += Time.deltaTime;
        timer.text = "" + time;
    }
}
