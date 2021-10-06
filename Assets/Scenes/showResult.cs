using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showResult : MonoBehaviour
{
    public int score;
    private bool isClick = false;

    void Start()
    {
        //GameObject.FindWithTag("manager").GetComponent<score>().right;
        //GameObject[] occupied = GameObject.FindGameObjectsWithTag("occupied");
    }

    public void click()
    {
        if (isClick == false)
        {
            score = GameObject.FindWithTag("manager").GetComponent<score>().right;
            GameObject[] occupied = GameObject.FindGameObjectsWithTag("occupied");
            GameObject[] ghostframe = GameObject.FindGameObjectsWithTag("ghostframe");
            if (score == occupied.Length&&ghostframe.Length == 0)
            {
                gameObject.GetComponent<UnityEngine.UI.Text>().text = "Congratulations!";
                gameObject.SetActive(true);
                
            }
            else
            {
                gameObject.GetComponent<UnityEngine.UI.Text>().text = "Try again!";
                gameObject.SetActive(true);
                
            }


            //isClick = true;
        }
        else
        {
            //gameObject.SetActive(false);
            //isClick = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
