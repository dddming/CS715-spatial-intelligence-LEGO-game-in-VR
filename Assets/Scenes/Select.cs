using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    
    public GameObject selected;
    public Color RGB;
    GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        selected = GameObject.FindWithTag("manager");
        arrow = GameObject.Find("arrow");
    }

    // Update is called once per frame
    void Update() 
    {        
        
        if (Input.GetMouseButtonDown(0))
        {            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;          
            if (Physics.Raycast(ray, out hit))
            {
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
               else if(hit.transform.gameObject.tag == "bricks")
               {
                   if(selected != hit.transform.gameObject && selected.tag != "manager" && selected.tag != "table")
                    {
                        //GameObject.Find("arrow").transform.position = new Vector3(hit.transform.position.x , hit.transform.position.y + 0.2f, hit.transform.position.z );
                        selected.GetComponent<Rigidbody>().useGravity = true;
                        selected.GetComponent<Rigidbody>().isKinematic = false;
                    }
                    
                        hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = false;
                        hit.transform.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                    
                    

                    
                    
                    print(hit.transform.gameObject.GetComponent<WasSelected>());
                   hit.transform.gameObject.GetComponent<WasSelected>().value = true;
                   selected = hit.transform.gameObject;
              //   Transform[] current = selected.GetComponentsInChildren<Transform>(true);
              //  RGB = current[1].GetComponent<MeshRenderer>().material.color;
              //for (int i = 1; i < current.Length; i++)
              //   {
                        
              //        current[i].GetComponent<selectedeffect>().enabled = true;
              //      }

              //  }
              //  else
              //  {
              //     Transform[] current = selected.GetComponentsInChildren<Transform>(true);
              //    for (int i = 1; i < current.Length; i++)                    {
                      
              //          current[i].GetComponent<MeshRenderer>().material.color = RGB;
              //          current[i].GetComponent<selectedeffect>().enabled = false;
              //      }
                    
                }
            }

        }
        if (selected != null)
        {
            if(selected.gameObject.tag == "bricks")
            {
                if (Input.GetAxis("Mouse ScrollWheel") < 0)
                {
                    //transform.position.z = transform.position.z - 1;
                    //print(transform.position.z - transform.position.y);
                    //selected.GetComponent<myDrag>().canDrag = false;
                    //transform.position = new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z );                
                    //selected.transform.Translate(Vector3.back * Time.deltaTime * 1.5F);

                    selected.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y ,selected.transform.position.z - Time.deltaTime * 2.5F);
                    arrow.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y + 0.2f, selected.transform.position.z);



                }
                if (Input.GetAxis("Mouse ScrollWheel") > 0)
                {
                    //transform.position.z = transform.position.z - 1;
                    //print(transform.position.z - transform.position.y);

                    //transform.position = new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z );
                    //selected.transform.Translate(Vector3.right * Time.deltaTime * 1.5F);
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
