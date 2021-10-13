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
            if (score == FindObjectsOfType<position>().Length - GameObject.FindGameObjectsWithTag("bricks").Length)
            {
                var gobject = Find("GUI");
                var gobject_TEXT = Find("Result");
                gobject.SetActive(true);
                gobject_TEXT.GetComponent<UnityEngine.UI.Text>().text = "Congratulations!";
                gobject_TEXT.SetActive(true);
                var gobject_close = Find("Close");
                gobject_close.SetActive(true);


            }
            else
            {
                var gobject = Find("GUI");
                var gobject_TEXT = Find("Result");
                gobject.SetActive(true);
                gobject_TEXT.GetComponent<UnityEngine.UI.Text>().text = "Try again!";
                gobject_TEXT.SetActive(true);
                var gobject_close = Find("Close");
                gobject_close.SetActive(true);
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
