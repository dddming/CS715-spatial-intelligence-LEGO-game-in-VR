using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class CheckResult : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> cubes;
    public List<GameObject> frames;
    public List<bool> checkTreeMatch;
    public int countMatch = 0;
    private bool supportvalue = false;


    void Start()
    {
        checkTreeMatch = new List<bool>();
        for (int i = 0; i < 11; i++) {
            checkTreeMatch.Add(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fp = frames[0].transform.position;
        Vector3 x = cubes[0].transform.position;


        for (int i = 0; i < 6; i++) {
            if (frames[i].transform.position == cubes[5].transform.position || frames[i].transform.position == cubes[6].transform.position || frames[i].transform.position == cubes[7].transform.position ||
        frames[i].transform.position == cubes[8].transform.position || frames[i].transform.position == cubes[9].transform.position || frames[i].transform.position == cubes[10].transform.position)
            {
                checkTreeMatch[i] = true;

            }
            else {
                checkTreeMatch[i] = false;
            }
        }
        for (int j = 6; j < checkTreeMatch.Count; j++) {
            if (frames[j].transform.position == cubes[0].transform.position || frames[j].transform.position == cubes[1].transform.position || frames[j].transform.position == cubes[2].transform.position ||
                frames[j].transform.position == cubes[3].transform.position || frames[j].transform.position == cubes[4].transform.position)
            {
                checkTreeMatch[j] = true;

            }
            else
            {
                checkTreeMatch[j] = false;
            }
        }

       int trueCount = checkTreeMatch.Sum(x => x ? 1 : 0);
       Debug.Log(trueCount);



    }


}
