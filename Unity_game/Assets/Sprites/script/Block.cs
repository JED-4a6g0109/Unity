using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Block : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        
        int caseSwitch = Random.Range(0, 6);//Random 0-5
        

        switch (caseSwitch)//隨機天降buff
        {
            case 0:
                Instantiate(GameObject.Find("width (2)"), transform.position, transform.rotation);//add clone width
                break;
            case 1:
                Instantiate(GameObject.Find("unwidth (2)"), transform.position, transform.rotation);// add clone unwidth
                break;
            case 2:
                Instantiate(GameObject.Find("cloneball"), transform.position, transform.rotation);//add clone ball
                break;

            default:
                Destroy(gameObject);//delete gameObject
                break;
        }
        Destroy(gameObject);//delete gameObject


    }

}

