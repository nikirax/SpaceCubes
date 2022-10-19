using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoNextScene : MonoBehaviour
{
    public GameObject Canvas;
    public InputField Speed;
    public InputField Time;
    public InputField Distance;
    // Start is called before the first frame update
    void Start()
    {
        Data.Speed = float.Parse(Speed.text);
        Data.Distance = float.Parse(Distance.text);
        Data.Time = float.Parse(Time.text);
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextScene);
    }
}
