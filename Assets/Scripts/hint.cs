using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class hint : MonoBehaviour
{
    private int count;
    
    private bool isClick = false;
    private bool isPictureAppeared = false;
    public void click()
    {
        if (isClick == false)
        {
            GameObject task = Find("Task4");
            if (!isPictureAppeared &&task.activeSelf && GameObject.FindWithTag("placeholder").GetComponent<Switch>().currentTime == 0f)
            {
                GameObject.FindWithTag("placeholder").GetComponent<Switch>().currentTime = 3f;
                isPictureAppeared = true;
            }
            //GameObject task = GameObject.FindGameObjectsWithTag("ghostframe");
            GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
            try
            {
                GameObject selected = GameObject.Find("GameManager").GetComponent<Select>().selected;
                Transform[] current = selected.GetComponentsInChildren<Transform>(true);
                for (int i = 0; i < cubes.Length; i++)
                {
                    try
                    {
                        if (current[1].GetComponent<position>().p == cubes[i].GetComponent<position>().p)
                        {
                            cubes[i].GetComponent<flash>().enabled = true;
                        }
                    }
                    catch (System.Exception e)
                    {

                    }



                }
            }
            catch (System.Exception e)
            {
                
            }
     
        }
        else
        {
            //gameObject.SetActive(false);
            //isClick = false;
        }
        
    }
    void Start()
    {
        //count = GameObject.FindGameObjectsWithTag("ghostframe").Length + GameObject.FindGameObjectsWithTag("occupied").Length;
    }

    void Update()
    {
        //gameObject.GetComponent<UnityEngine.UI.Text>().text = GameObject.FindWithTag("manager").GetComponent<score>().right.ToString() + "/" + count.ToString();
    }
    public static GameObject Find(string name)
    {
        UnityEngine.Object[] objs = Resources.FindObjectsOfTypeAll(typeof(GameObject));

        foreach (GameObject obj in objs)
        {
            if (obj.name == name)
            {
                return obj;
            }
        }

        return null;
    }
}
