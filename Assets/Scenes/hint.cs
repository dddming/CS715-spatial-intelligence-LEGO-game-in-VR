using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hint : MonoBehaviour
{
    private int count;
    
    private bool isClick = false;
    public void click()
    {
        if (isClick == false)
        {
            GameObject task = GameObject.Find("Task1");
            Transform[] cubes = task.GetComponentsInChildren<Transform>(true);
            try
            {
                GameObject selected = GameObject.Find("GameManager").GetComponent<Select>().selected;
                Transform[] current = selected.GetComponentsInChildren<Transform>(true);
                for (int i = 1; i < cubes.Length; i++)
                {
                    if (current[1].GetComponent<position>().p == cubes[i].GetComponent<position>().p)
                    {
                        cubes[i].GetComponent<flash>().enabled = true;
                    }

                }
            }
            catch (System.Exception e)
            {
                
            }
                       
                      
            //isClick = true;
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
}
