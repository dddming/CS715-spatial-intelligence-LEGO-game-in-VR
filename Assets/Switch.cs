using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] background;
    int index;

    float currentTime = 0f;
    float startingTime = 10f;

    public Text countdownText;
    void Start()
    {
        index = 0;
        currentTime = startingTime;

    }

    // Update is called once per frame
    void Update()
    {

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

        }
        if (index == 3)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
            if (currentTime <= 0) {
                currentTime = 0;
                background[3].gameObject.SetActive(false);
            }
        }

    }
    public void Previous() { 
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
        }
    }
    public void Next() {
        if (index != 6)
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
