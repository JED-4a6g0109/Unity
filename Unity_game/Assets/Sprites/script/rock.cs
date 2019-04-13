using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rock : MonoBehaviour
{
    int count = 0;//attack count
    void Start()
    {

    }

    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        count += 1;//count +1
        if(count>1)//大於2才會消掉物件
        {
            
            Destroy(gameObject);


        }

    }

}

