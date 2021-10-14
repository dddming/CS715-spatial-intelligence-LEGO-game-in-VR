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
                GameObject task = Find("Task4");
                    if (task.activeSelf){
                        GameObject image = Find("ImageM");
                        image.SetActive(true);
                        new WaitForSeconds(3);
                        // image.SetActive(false);

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
    public static GameObject Find(string name)
    {
        Object[] objs = Resources.FindObjectsOfTypeAll(typeof(GameObject));

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
