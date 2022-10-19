using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Delete_Cubes : MonoBehaviour
{
    public GameObject Cube;
    public float Distance;
    public Transform Cube_Pos;
    void Start()
    {
        Distance = Data.Distance;
    }
    void FixedUpdate()
    {
        if (Cube_Pos.position.x > Distance)
            Destroy(Cube);
    }
}
