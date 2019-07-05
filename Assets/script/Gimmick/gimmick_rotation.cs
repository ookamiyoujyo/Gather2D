using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmick_rotation : MonoBehaviour
{
    public GameObject rotation_Object;
    public float Rotate_Speed = 15f;
    void Update()
    {
        rotation_Object.transform.Rotate(new Vector3(0, 0, Rotate_Speed) * Time.deltaTime, Space.World);
    }
}