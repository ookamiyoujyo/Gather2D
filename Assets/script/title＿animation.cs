using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title＿animation : MonoBehaviour
{
    public GameObject[] titleanimal;
    int fara = 0;
    int random;
    public void suta()
    {
        fara = 1;
    }


    private float timeleft;

    void Update()
    {
            timeleft -= Time.deltaTime;
            if (timeleft <= 0.0)
            {
            timeleft = Random.Range(6, 10);

            random = Random.Range(0, 10);


                Instantiate(titleanimal[random]);
            }
    }
}
