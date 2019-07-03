using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public GameObject Main_Player, Player;
    public float speed = 5, Rotate_Speed = 50;
    static string control_Permission;
    public enum control
    {
        play,
        stop,
    }
    private void Start()
    {
        control control = control.play;
        control_Permission = control.ToString();
    }

    void Update()
    {

        if (control_Permission == "play")
        {
            if (Input.GetKey("up"))
            {
                Main_Player.transform.position += Main_Player.transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey("down"))
            {
                Main_Player.transform.position -= Main_Player.transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey("right"))
            {
                Main_Player.transform.position += Main_Player.transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey("left"))
            {
                Main_Player.transform.position -= Main_Player.transform.right * speed * Time.deltaTime;
            }
            Player.transform.Rotate(new Vector3(0, 0, Rotate_Speed) * Time.deltaTime, Space.World);
        }
    }
    public static void controoff()
    {
        control control = control.stop;
        control_Permission = control.ToString();
    }
}
