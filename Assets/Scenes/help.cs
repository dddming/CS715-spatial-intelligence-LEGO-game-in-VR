using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
    private int count;
    private bool isClick = false;
    public void click()
    {
        if(isClick == false)
        {            
            gameObject.SetActive(true);
            isClick = true;
        }
        else
        {
            gameObject.SetActive(false);
            isClick = false;
        }
    }
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("ghostframe").Length + GameObject.FindGameObjectsWithTag("occupied").Length;
    }

    void Update()
    {
        gameObject.GetComponent<UnityEngine.UI.Text>().text = GameObject.FindWithTag("manager").GetComponent<score>().right.ToString() + "/" + count.ToString();
    }
}