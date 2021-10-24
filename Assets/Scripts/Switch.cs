using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject[] background;
    int index;
    public float currentTime = 0f;
    float startingTime = 10f;
    GameObject arrow;

    public Text countdownText;
    //Initial variables,timer,and pre-locate hidden objects 
    void Start()
    {
        index = 0;
        currentTime = startingTime;
        arrow = GameObject.Find("arrow");
    }

    void Update()
    {
        //Initiate game stae
        if (index == 0) {
            background[0].gameObject.SetActive(true);
            var levelone = Find("Task1");
            levelone.SetActive(true);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(true);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        //end with the fourth task 
        if (index == 3)
        {
            if (currentTime > 0)
            {
                background[3].gameObject.SetActive(true);
                currentTime -= 1 * Time.deltaTime;
                countdownText.text = currentTime.ToString("0");
                if (currentTime <= 0)
                {
                    currentTime = 0;
                    background[3].gameObject.SetActive(false);
                }
            }
        }

    }
    //**********************************************************************************************************
    // This function is not used now
    // It is designed to switch back to previous tasks, which is currently disabled in current version
    //**********************************************************************************************************
    public void Previous() {
        GameObject.FindWithTag("manager").GetComponent<score>().right = 0;
        if (index != 0)
        {
            index -= 1;
        }
        for (int i = 0; i<background.Length; i++) {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        if (index == 0)
        {
            var levelone = Find("Task1");
            levelone.SetActive(true);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(true);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);
        }
        else if (index == 1)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(true);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(true);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 2)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(true);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(true);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 3)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(true);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(true);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 4)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(true);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(true);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 5){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(true);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(true);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index==6){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(true);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(true);

        }
        else if(index == 7){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(true);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);
        }
    }
    //By clicking the next task button, clear all the used elements and switch to newx task
    public void Next() {
        arrow.SetActive(true);
        arrow.transform.position = new Vector3(999, 999, 999);
        GameObject.FindWithTag("manager").GetComponent<score>().right = 0;
        //Stop by fourth task
        if (index != 3)
        {
            index += 1;
        }
        for (int i = 0; i < background.Length; i++) {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        if (index == 0)
        {
            var levelone = Find("Task1");
            levelone.SetActive(true);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(true);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 1)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(true);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(true);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 2)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(true);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(true);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 3)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(true);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(true);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 4)
        {
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(true);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(true);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index == 5){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(true);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(true);
            var object7 = Find("level7-objects");
            object7.SetActive(false);

        }
        else if (index==6){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(true);
            var leveleight = Find("Task8");
            leveleight.SetActive(false);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(true);

        }
        else if(index == 7){
            var levelone = Find("Task1");
            levelone.SetActive(false);
            var leveltwo = Find("Task2");
            leveltwo.SetActive(false);
            var levelthree = Find("Task3");
            levelthree.SetActive(false);
            var levelfour = Find("Task4");
            levelfour.SetActive(false);
            var levelfive = Find("Task5");
            levelfive.SetActive(false);
            var levelsix = Find("Task6");
            levelsix.SetActive(false);
            var levelseven = Find("Task7");
            levelseven.SetActive(false);
            var leveleight = Find("Task8");
            leveleight.SetActive(true);
            var object1 = Find("level1-objects");
            object1.SetActive(false);
            var object2 = Find("level2-objects");
            object2.SetActive(false);
            var object3 = Find("level3-objects");
            object3.SetActive(false);
            var object4 = Find("level4-objects");
            object4.SetActive(false);
            var object5 = Find("level5-objects");
            object5.SetActive(false);
            var object6 = Find("level6-objects");
            object6.SetActive(false);
            var object7 = Find("level7-objects");
            object7.SetActive(false);
        }

        var next_step = Find("Begin");
        next_step.SetActive(false);
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
