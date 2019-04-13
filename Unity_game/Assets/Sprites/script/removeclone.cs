using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeclone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        //刪除克隆以免佔記憶體
        if (collision.gameObject.name.Substring(0, 5) == "width") 
        {
            Destroy(collision.gameObject); 
        }
        if (collision.gameObject.name.Substring(0, 7) == "unwidth") 
        {
            Destroy(collision.gameObject); 
        }
        if (collision.gameObject.name.Substring(0, 8) == "copyball") 
        {
            Destroy(collision.gameObject); 
        }
        if (collision.gameObject.name.Substring(0, 4) == "ball") 
        {
            Destroy(collision.gameObject); 
        }
    }
}