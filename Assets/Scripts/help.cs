using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour
{
    private int count;
    private bool isClick = false;
    public void click()
    {
        //Once click help button, Will show correct cube out of target cube. 
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
        
    }

    void Update()
    {
        // Update correct cube number after each move
        count = FindObjectsOfType<position>().Length - GameObject.FindGameObjectsWithTag("bricks").Length;
        gameObject.GetComponent<UnityEngine.UI.Text>().text = GameObject.FindWithTag("manager").GetComponent<score>().right.ToString() + "/" + count.ToString();
    }
}
