using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class flash : MonoBehaviour
{
    public float shake;
    private MeshRenderer BoxColliderClick;
    void Start()
    {
        BoxColliderClick = gameObject.GetComponent<MeshRenderer>();
    }

    //Flash the responding ghostframe by enabling/disabling the MeshRenderer, last for 3.5 second.
    void Update()
    {
        if(shake <= 3.5)
        {
            shake += Time.deltaTime;
        }        

        if (shake % 1 > 0.5f)
        {
            BoxColliderClick.enabled = true;
        }
        else
        {
            BoxColliderClick.enabled = false;
        }      

        
    }
}