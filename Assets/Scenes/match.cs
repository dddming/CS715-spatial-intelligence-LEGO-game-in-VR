using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class match : MonoBehaviour
{
    public bool canmatch = false;
    int[] matched = new int[200];
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        if (canmatch){
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
            GameObject[] bricks = GameObject.FindGameObjectsWithTag("bricks");
            int check = 0;
            int right = 0;
            int[] temp = new int[200];
            for (int i = 0; i < bricks.Length; i++)
            {
                for (int j = 0; j < cubes.Length; j++)
                {
                    if ((Math.Abs(bricks[i].transform.position.x - cubes[j].transform.position.x) < 0.05) && (Math.Abs(bricks[i].transform.position.y - cubes[j].transform.position.y) < 0.05) && (Math.Abs(bricks[i].transform.position.z - cubes[j].transform.position.z) < 0.05))
                    {
                        bricks[i].transform.position = cubes[j].transform.position;
                        bricks[i].transform.rotation = cubes[j].transform.rotation;                        
                        cubes[j].tag = "occupied";
                        cubes[j].GetComponent<MeshRenderer>().enabled = false;
                        matched[j] = 1;
                        temp[j] = 1;
                    }
                    
                }
            }
        if (Time.frameCount % 70 == 0)
        {
            
            }
            //GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
            //for (int i = 0; i < cubes.Length; i++)
            //{
            //    Collider[] colliders = Physics.OverlapSphere(cubes[i].transform.position, 0.05f);
            //    print(colliders);
            //    if(colliders.Length > 1)
            //    {
            //        colliders[1].gameObject.transform.position = cubes[i].transform.position;
            //        colliders[1].gameObject.transform.rotation = cubes[i].transform.rotation;

            //    }

            //}

        }


       

        
    }
}
