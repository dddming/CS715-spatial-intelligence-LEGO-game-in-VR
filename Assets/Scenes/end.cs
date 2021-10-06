using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    GameObject[] cubes;
    GameObject confirm;
    void Start()
    {
        
        confirm.SetActive(false);
    }
    void Awake()
    {
        confirm = GameObject.Find("ConfirmButton");
    }



    void Update()
    {
        cubes = GameObject.FindGameObjectsWithTag("ghostframe");
        if(cubes.Length == 0)
        {            
            confirm.SetActive(true);
        }
        
    }
}
