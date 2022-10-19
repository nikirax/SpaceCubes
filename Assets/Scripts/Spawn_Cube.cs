using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Cube : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Cube;
    public float timeSpawn;
    // Start is called before the first frame update
    void Start()
    {
        timeSpawn = Data.Time;
        StartCoroutine(SpawnCD());
    }

    // Update is called once per frame
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(timeSpawn);
        Instantiate(Cube, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
