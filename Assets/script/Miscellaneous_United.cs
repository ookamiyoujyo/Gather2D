using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscellaneous_United : MonoBehaviour
{
    public GameObject Player;

    public GameObject Geteffect, killeffect;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Miscellaneous food" || other.gameObject.tag == "Meat food" || other.gameObject.tag == "Herbivores")
        {
            foreach (ContactPoint point in other.contacts)
            {
                Instantiate(Geteffect, point.point, Quaternion.identity);
            }
            transform.parent = Player.transform;
        }
        if (other.gameObject.tag == "no touch")
        {
            foreach (ContactPoint point in other.contacts)
            {
                Instantiate(killeffect, point.point, Quaternion.identity);
            }
            Player_Move.controoff();
        }
    }
}
