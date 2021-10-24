using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showResult : MonoBehaviour
{
    public int score;
    private bool isClick = false;

    //Show the feedback of the game, after user clicked the confirm button
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
        }
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
