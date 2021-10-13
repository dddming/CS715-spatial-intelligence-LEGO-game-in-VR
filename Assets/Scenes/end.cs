using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    GameObject[] cubes;
    GameObject confirm;
    void Start()
    {
    }
    void Awake()
    {
        confirm = GameObject.Find("ConfirmButton");
    }



    void Update()
    {
        cubes = GameObject.FindGameObjectsWithTag("occupied");
        var fill = FindObjectsOfType<position>().Length - GameObject.FindGameObjectsWithTag("bricks").Length;
        if (cubes.Length == fill)
        {
            confirm.SetActive(true);
        }
        else
        {
            confirm.SetActive(false);
        }
        
    }
}
