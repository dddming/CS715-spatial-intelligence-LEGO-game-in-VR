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
    bool canZoom = false;
    BoxCollider m_Collider;
    float m_ScaleX, m_ScaleY, m_ScaleZ;
    public Slider m_SliderX, m_SliderY, m_SliderZ;
    public bool canDrag = true;
    public int count;
    GameObject arrow;

    void Start()
    {
        count = GameObject.FindGameObjectsWithTag("ghostframe").Length;
        arrow = GameObject.Find("arrow");
    }




    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        mOffset = gameObject.transform.position - GetMouseWorldPos();

        print(mOffset);

        canRotate = true;
        canZoom = true;



        //GameObject parent = gameObject.transform.parent.gameObject;
        //GameObject mobject = transform.gameObject;
        Transform[] bricks = GetComponentsInChildren<Transform>();
        //print(bricks[1].name);

        GameObject[] occupied = GameObject.FindGameObjectsWithTag("occupied");
        //GameObject[] bricks = GameObject.FindGameObjectsWithTag("brick1");
        //GameObject parent = bricks[1].transform.parent.gameObject;
        gameObject.GetComponent<Collider>().isTrigger = false;
        
        if (gameObject == GameObject.FindWithTag("manager").GetComponent<Select>().selected)
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        //gameObject.GetComponent<Rigidbody>().isKinematic = true;
        //gameObject.GetComponent<Rigidbody>().useGravity = true;

        // parent.GetComponent<Collider>().isTrigger = true;


        //for (int k = 0; k < bricks.Length; k++)
        //{
        //   bricks[k].GetComponent<Collider>().isTrigger = false;
        // }

        //for (int k = 0; k < bricks.Length; k++){
        //    bricks[k].GetComponent<Collider>().isTrigger = false;
        //}





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

        // occupied = GameObject.FindGameObjectsWithTag("occupied");
        // if (GameObject.FindWithTag("manager").GetComponent<score>().right > occupied.Length)
        // {            GameObject.FindWithTag("manager").GetComponent<score>().right -= 1;

        // }
        //GameObject.FindWithTag("resultText").GetComponent<Text>().text = GameObject.FindWithTag("manager").GetComponent<score>().right.ToString() + "/" + count.ToString();
    }

    void move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 0.5F);
        }
    }

    void OnMouseUp()
    {
        canRotate = false;
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
        Transform[] bricks = GetComponentsInChildren<Transform>();
        m_Collider = GetComponent<BoxCollider>();
        int check = 0;

        //if (gameObject == GameObject.FindWithTag("manager").GetComponent<Select>().selected)
        //{ 
        //    gameObject.GetComponent<Rigidbody>().useGravity = false;
        //    gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
        //}
        //gameObject.GetComponent<Rigidbody>().isKinematic = false;
        int right = 0;

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

            if (check == bricks.Length - 1)
            {

                for (int z = 1; z < bricks.Length; z++)
                {
                    gameObject.GetComponent<Rigidbody>().useGravity = false;
                    
                    bricks[z].transform.position = cubes[match[z]].transform.position;
                    bricks[z].transform.rotation = cubes[match[z]].transform.rotation;
                    //bricks[z].GetComponent<Collider>().isTrigger = true;
                    cubes[match[z]].GetComponent<MeshRenderer>().enabled = false;
                    cubes[match[z]].tag = "occupied";
                    bricks[z].GetComponent<Collider>().isTrigger = true;
                    arrow.SetActive(false);
                    GameObject.FindWithTag("manager").GetComponent<Select>().selected = GameObject.FindWithTag("table");
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

            

            if (right == bricks.Length - 1)
            {
                GameObject.FindWithTag("manager").GetComponent<score>().right += 1;
               // GameObject.FindWithTag("resultText").GetComponent<Text>().text = GameObject.FindWithTag("manager").GetComponent<score>().right.ToString() + "/" +count.ToString() ;
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

    void OnMouseDrag()
    {
        print((GetMouseWorldPos() + mOffset).z);



        //if((GetMouseWorldPos() + mOffset).x <= -9.3 || (GetMouseWorldPos() + mOffset).x > -7)
        //{
        //    transform.position = GetMouseWorldPos() + mOffset;
        //}
        arrow.SetActive(true);
        transform.position = GetMouseWorldPos() + mOffset;
        
        if (transform.position.x >= -9.3 && transform.position.x <= -7 &&transform.position.y <= 3.5)
        {
            
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z);
            

        }
        arrow.transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);



        //transform.position = GetMouseWorldPos() + mOffset;

        // transform.position += mOffset;

    }

    void Update()
    {

        if (canRotate)
        {
            move();
            if (Input.GetKey(KeyCode.J))
            {
                transform.Rotate(0, 0.5f, 0);
            }
            if (Input.GetKey(KeyCode.L))
            {
                transform.Rotate(0, -0.5f, 0);
            }
            if (Input.GetKey(KeyCode.I))
            {
                transform.Rotate(0.5f, 0, 0);
            }
            if (Input.GetKey(KeyCode.K))
            {
                transform.Rotate(-0.5f, 0, 0);
            }
        }







    }
}
