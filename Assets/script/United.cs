using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class United : MonoBehaviour
{
    public GameObject Player;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            transform.parent = Player.transform;
        }
    }
}