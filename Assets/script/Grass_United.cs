using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass_United : MonoBehaviour
{
    public GameObject Player;

    public GameObject Geteffect,noeffect, killeffect;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Miscellaneous food" || other.gameObject.tag == "Herbivores")
        {
            foreach (ContactPoint point in other.contacts)
            {
                Instantiate(Geteffect, point.point, Quaternion.identity);
            }
            transform.parent = Player.transform;
        }

        if(other.gameObject.tag == "Meat food")
        {
            foreach (ContactPoint point in other.contacts)
            {
                Instantiate(noeffect, point.point, Quaternion.identity);
            }
        }

            if (other.gameObject.tag ==  "no touch")
        {
            foreach (ContactPoint point in other.contacts)
            {
                Instantiate(killeffect, point.point, Quaternion.identity);
            }
            Player_Move.controoff();
        }
    }
}
