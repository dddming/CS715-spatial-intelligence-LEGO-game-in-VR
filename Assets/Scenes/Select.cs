using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public GameObject selected;
    public Color RGB;
    // Start is called before the first frame update
    void Start()
    {
        
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
               if (hit.transform.gameObject.tag == "bricks")
               {
                   print(hit.transform.gameObject.GetComponent<WasSelected>());
                   hit.transform.gameObject.GetComponent<WasSelected>().value = true;
                   selected = hit.transform.gameObject;
                 Transform[] current = selected.GetComponentsInChildren<Transform>(true);
                RGB = current[1].GetComponent<MeshRenderer>().material.color;
              for (int i = 1; i < current.Length; i++)
                 {
                        
                      current[i].GetComponent<selectedeffect>().enabled = true;
                    }

                }
                else
                {
                   Transform[] current = selected.GetComponentsInChildren<Transform>(true);
                  for (int i = 1; i < current.Length; i++)                    {
                      
                        current[i].GetComponent<MeshRenderer>().material.color = RGB;
                        current[i].GetComponent<selectedeffect>().enabled = false;
                    }
                    
                }
            }

        }
        if (selected != null)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                //transform.position.z = transform.position.z - 1;
                //print(transform.position.z - transform.position.y);

                //transform.position = new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z );
                selected.transform.Translate(Vector3.left * Time.deltaTime * 1.5F);
                selected.transform.Translate(Vector3.back * Time.deltaTime * 1.5F);
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                //transform.position.z = transform.position.z - 1;
                //print(transform.position.z - transform.position.y);

                //transform.position = new Vector3(transform.position.x - 3f, transform.position.y, transform.position.z );
                selected.transform.Translate(Vector3.right * Time.deltaTime * 1.5F);
                selected.transform.Translate(Vector3.forward * Time.deltaTime * 1.5F);
            }
        }
    }
}
