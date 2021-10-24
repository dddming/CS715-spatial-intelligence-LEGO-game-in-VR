using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    
    public GameObject selected;
    GameObject arrow;
    //Pre-locate hidden objects
    void Start()
    {
        selected = GameObject.FindWithTag("manager");
        arrow = GameObject.Find("arrow");
    }

    void Update() 
    {      
        //If user clicked the left mouse button
        if (Input.GetMouseButtonDown(0))
        {   
            //Use rayhit to detect the first brick
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;          
            if (Physics.Raycast(ray, out hit))
            {
               //Cancel the selection by clicking table
               if(hit.transform.gameObject.tag == "table")
               {
                    
                    if(selected.tag != "table" && selected.tag != "manager")
                    {
                        GameObject.Find("arrow").SetActive(false);
                        selected.GetComponent<Rigidbody>().useGravity = true;
                        selected.GetComponent<Rigidbody>().isKinematic = false;
                        selected = hit.transform.gameObject;
                    }                   
               }
               //Change the current and precious selected object's physic
               else if(hit.transform.gameObject.tag == "bricks")
               {
                   if(selected != hit.transform.gameObject && selected.tag != "manager" && selected.tag != "table")
                    {                
                        selected.GetComponent<Rigidbody>().useGravity = true;
                        selected.GetComponent<Rigidbody>().isKinematic = false;
                    }                    
                   hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = false;
                   hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;                   
                   hit.transform.gameObject.GetComponent<WasSelected>().value = true;
                   selected = hit.transform.gameObject; 
                }
            }
        }
        if (selected != null)
        {
            if(selected.gameObject.tag == "bricks")
            {
                //Use mouse scroll the move the slected brick towards or far away from the camera.
                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                    selected.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y ,selected.transform.position.z - Time.deltaTime * 2.5F);
                    arrow.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y + 0.2f, selected.transform.position.z);
                }
                if (Input.GetAxis("Mouse ScrollWheel") > 0)
                {
                    selected.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y, selected.transform.position.z + Time.deltaTime * 2.5F);
                    arrow.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y + 0.2f, selected.transform.position.z);
                }
            }
            if(Input.GetKey(KeyCode.A))
            {
                selected.transform.Rotate(0, 0.5f, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                selected.transform.Rotate(0, -0.5f, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                selected.transform.Rotate(0.5f, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                selected.transform.Rotate(-0.5f, 0, 0);
            }

        }
        


    }
}
