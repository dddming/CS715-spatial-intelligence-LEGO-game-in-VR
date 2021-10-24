using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;

public class myDrag : MonoBehaviour
{
    private Vector3 mOffset;
    private float mZCoord;
    float rotSpeed = 10;
    bool canRotate = false;
    BoxCollider m_Collider;
    float m_ScaleX, m_ScaleY, m_ScaleZ;
    public Slider m_SliderX, m_SliderY, m_SliderZ;
    public bool canDrag = true;
    public int count;
    GameObject arrow;

    //Pre-locate hidden objects
    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("ghostframe").Length;
        arrow = GameObject.Find("arrow");
    }

    //When user click the left mouse button
    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();
        canRotate = true; 
        //Find all bricks and birck-attached ghostframe 
        Transform[] bricks = GetComponentsInChildren<Transform>();
        GameObject[] occupied = GameObject.FindGameObjectsWithTag("occupied");
        //Change Physics
        gameObject.GetComponent<Collider>().isTrigger = false;
        if (gameObject == GameObject.FindWithTag("manager").GetComponent<Select>().selected)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        //Detach the brick from ghostframe and recalculate the score if applicatable
        for (int i = 0; i < occupied.Length; i++)
        {
            var temp = occupied[i].transform.position;
            for (int j = 1; j < bricks.Length; j++)
            {
                bricks[j].GetComponent<Collider>().isTrigger = false;
                if ((Math.Abs(bricks[j].transform.position.x - temp.x) < 0.05) && (Math.Abs(bricks[j].transform.position.y - temp.y) < 0.05) && (Math.Abs(bricks[j].transform.position.z - temp.z) < 0.05))
                {
                    occupied[i].GetComponent<MeshRenderer>().enabled = true;
                    occupied[i].tag = "ghostframe";
                    if (bricks[j].GetComponent<position>().p == occupied[i].GetComponent<position>().p)
                    {
                        GameObject.FindWithTag("manager").GetComponent<score>().right -= 1;
                    }
                }
            }
        }
    }

    //When user released the left mouse button
    void OnMouseUp()
    {
        canRotate = false;
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
        Transform[] bricks = GetComponentsInChildren<Transform>();
        m_Collider = GetComponent<BoxCollider>();
        int check = 0;
        int right = 0;
        //Check the matches to ghostframe based on every single-cube unit, make the script available for complex brick shapes.
        int[] match = new int[bricks.Length * 2];
        for (int i = 0; i < cubes.Length; i++)
        {
            var temp = cubes[i].transform.position;
            for (int j = 1; j < bricks.Length; j++)
            {
                if ((Math.Abs(bricks[j].transform.position.x - temp.x) < 0.08) && (Math.Abs(bricks[j].transform.position.y - temp.y) < 0.08) && (Math.Abs(bricks[j].transform.position.z - temp.z) < 0.08))
                {
                    match[j] = i;
                    check++;
                }
                if (j == bricks.Length && check != bricks.Length)
                {
                    check = 0;
                }
            }
            //All the units of the brick matched, then attach it to the ghostframe
            if (check == bricks.Length - 1)
            {
                for (int z = 1; z < bricks.Length; z++)
                {
                    gameObject.GetComponent<Rigidbody>().useGravity = false;
                    bricks[z].transform.position = cubes[match[z]].transform.position;
                    bricks[z].transform.rotation = cubes[match[z]].transform.rotation;
                    cubes[match[z]].GetComponent<MeshRenderer>().enabled = false;
                    cubes[match[z]].tag = "occupied";
                    bricks[z].GetComponent<Collider>().isTrigger = true;
                    arrow.SetActive(false);
                    GameObject.FindWithTag("manager").GetComponent<Select>().selected = GameObject.FindWithTag("table");
                    //Use try-catch to avoid console error
                    try
                    {
                        if (bricks[z].GetComponent<position>().p == cubes[match[z]].GetComponent<position>().p)
                        {
                            right += 1;
                        }
                    }
                    catch
                    {
                    }
                }
            }
            //Update the score to the manager
            if (right == bricks.Length - 1)
            {
                GameObject.FindWithTag("manager").GetComponent<score>().right += 1;
            }
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private Vector3 GetGhostFramePostion()
    {
        return GameObject.Find("GhostFrame").transform.position;
    }

    //When user darg the mouse
    void OnMouseDrag()
    {
        print((GetMouseWorldPos() + mOffset).z);
        //show the red arrow
        arrow.SetActive(true);
        transform.position = GetMouseWorldPos() + mOffset;
        //Limit the range of a brick can be dragged to
        if (transform.position.x >= -9.3 && transform.position.x <= -7 && transform.position.y <= 3.5)
        {
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
        }
        arrow.transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
    }

    void Update()
    {
        if (canRotate)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, 0.5f, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, -0.5f, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(0.5f, 0, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(-0.5f, 0, 0);
            }
        }







    }
}
