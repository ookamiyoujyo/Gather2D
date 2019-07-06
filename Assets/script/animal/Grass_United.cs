﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_United : MonoBehaviour
{
    public GameObject Player, gamemanager;

    public GameObject Geteffect,noeffect, killeffect,goalstar;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Miscellaneous food" || other.gameObject.tag == "Herbivores")
        {
            foreach (ContactPoint2D point in other.contacts)
            {
                Instantiate(Geteffect, point.point, Quaternion.identity);
            }
            gamemanager.GetComponent<Player_Move>().countnext();
            transform.parent = Player.transform;
            SE.play(0);
        }

        if(other.gameObject.tag == "Meat food")
        {
            foreach (ContactPoint2D point in other.contacts)
            {
                Instantiate(noeffect, point.point, Quaternion.identity);
            }
            SE.play(1);
        }

            if (other.gameObject.tag ==  "no touch")
        {
            foreach (ContactPoint2D point in other.contacts)
            {
                Instantiate(killeffect, point.point, Quaternion.identity);
            }
            Player_Move.controoff();
            gamemanager.GetComponent<Player_Move>().gameover();
            SE.play(2);
        }
        if (other.gameObject.tag == "goal")
        {
            foreach (ContactPoint2D point in other.contacts)
            {
                Instantiate(goalstar, point.point, Quaternion.identity);
            }
            gamemanager.GetComponent<Player_Move>().effectstart();
            SE.play(3);
        }
    }
}
