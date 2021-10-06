using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class selectedeffect : MonoBehaviour
{
    public float t = 0;
    float r, g, b;
    float ChangeTimeLength = 1.5f;
    
    void Start()
    {
        r = Random.Range(0f, 1f);
        g = Random.Range(0f, 1f);
        b = Random.Range(0f, 1f);

    }


    void Update()
    {
        t += Time.deltaTime;        
        if (t < ChangeTimeLength)
        {
            Color c = GetComponent<MeshRenderer>().material.color;
            GetComponent<MeshRenderer>().material.color = Color.Lerp(c, new Color(r, g, b, 1f), Time.deltaTime * 10);            
        }
        else if (t > ChangeTimeLength)
        {
            t = 0;
            r = Random.Range(0f, 1f);
            g = Random.Range(0f, 1f);
            b = Random.Range(0f, 1f);
        }


    }
}