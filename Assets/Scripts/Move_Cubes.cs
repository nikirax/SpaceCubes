using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Move_Cubes : MonoBehaviour
{
    public float Speed;
    public Vector3 vec;
    void Start()
    {
        Speed = Data.Speed;
    }
    void FixedUpdate()
    {
        transform.Translate(Speed *vec*Time.deltaTime, Space.World);
    }
}
