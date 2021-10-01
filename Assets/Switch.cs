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
    }
    public void Next() {
        if (index != 3)
        {
            index += 1;
        }

        for (int i = 0; i < background.Length; i++) {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
