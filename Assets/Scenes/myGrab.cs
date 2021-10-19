using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;
public class myGrab : OVRGrabbable
{

    Vector3 zero = new Vector3(0, 0, 0);
    BoxCollider m_Collider;
    protected override void Start()
    {
        base.Start();
        //count = GameObject.FindGameObjectsWithTag("ghostframe").Length;
    }

    
    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("occupied");
        gameObject.GetComponent<Collider>().isTrigger = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        for (int i = 0; i < cubes.Length; i++)
        {
            if ((Math.Abs(gameObject.transform.position.x - cubes[i].transform.position.x) < 0.05) && (Math.Abs(gameObject.transform.position.y - cubes[i].transform.position.y) < 0.05) && (Math.Abs(gameObject.transform.position.z - cubes[i].transform.position.z) < 0.05))
            {                
                cubes[i].tag = "ghostframe";
                cubes[i].GetComponent<MeshRenderer>().enabled = true;                
            }
        }
        base.GrabBegin(hand, grabPoint);
        //GameObject.FindWithTag("manager").GetComponent<match>().canmatch = false;
       
    }
    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        int matched = 0;
        GameObject[] cubes = GameObject.FindGameObjectsWithTag("ghostframe");
        for (int i = 0; i < cubes.Length; i++)
        {
            if ((Math.Abs(gameObject.transform.position.x - cubes[i].transform.position.x) < 0.05) && (Math.Abs(gameObject.transform.position.y - cubes[i].transform.position.y) < 0.05) && (Math.Abs(gameObject.transform.position.z - cubes[i].transform.position.z) < 0.05))
            {
                gameObject.transform.position = cubes[i].transform.position;
                gameObject.transform.rotation = cubes[i].transform.rotation;
                cubes[i].tag = "occupied";
                cubes[i].GetComponent<MeshRenderer>().enabled = false;
                matched = 1;
                gameObject.GetComponent<Collider>().isTrigger = true;
            }
        }
        if(matched == 0)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        base.GrabEnd(linearVelocity,angularVelocity);
       

    }


}
