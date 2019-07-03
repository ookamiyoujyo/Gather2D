using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miscellaneous_United : MonoBehaviour
{
    public GameObject Player;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Miscellaneous food" || other.gameObject.tag == "Meat food" || other.gameObject.tag == "Herbivores")
        {
            transform.parent = Player.transform;
        }
    }
}
