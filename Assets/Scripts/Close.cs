using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public void click()
    {
        var score = GameObject.FindWithTag("manager").GetComponent<score>().right;
        if (score == FindObjectsOfType<position>().Length - GameObject.FindGameObjectsWithTag("bricks").Length)
        {
            var gobject = Find("GUI");
            var gobject_TEXT = Find("Result");
            gobject.SetActive(false);
            gobject_TEXT.SetActive(false);
            var gobject_close = Find("Close");
            gobject_close.SetActive(false);
            if (!Find("Task4").activeSelf)
            {
                var next_step = Find("Begin");
                next_step.SetActive(true);
            }
        }
        else {
            var gobject = Find("GUI");
            var gobject_TEXT = Find("Result");
            gobject.SetActive(false);
            gobject_TEXT.SetActive(false);
            var gobject_close = Find("Close");
            gobject_close.SetActive(false);
            if (!Find("Task4").activeSelf)
            {
                var next_step = Find("Begin");
                next_step.SetActive(true);
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
