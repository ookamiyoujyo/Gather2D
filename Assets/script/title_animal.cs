using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_animal : MonoBehaviour
{
    public float speed = 5, Rotate_Speed = 50;
    public GameObject Main_Player, Player;
    private void Start()
    {
        Destroy(gameObject, 10.0f);
    }
    void Update()
    {
        Main_Player.transform.position += Main_Player.transform.up * speed * Time.deltaTime;
        Player.transform.Rotate(new Vector3(0, 0, Rotate_Speed) * Time.deltaTime, Space.World);
    }
}
