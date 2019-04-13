using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    public float speed = 150;//移動速度
    public float add=1f;//原始寬度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");//紀錄水平
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;//位移

    }

  
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Substring(0, 5) == "width") //racket變寬
        {
            add += 0.1f;
            transform.localScale = new Vector2(add, 1);//增加0.1f寬度
            Destroy(collision.gameObject); //刪除碰撞到的物件
        }

        if (collision.gameObject.name.Substring(0, 7) == "unwidth") //racket縮減寬度
        {
            add -= 0.1f;
            transform.localScale = new Vector2(add, 1);//減少0.1f寬度
            Destroy(collision.gameObject); //刪除碰撞到的物件
        }

        if (collision.gameObject.name.Substring(0, 9) == "cloneball") //克隆球
        {
            Instantiate(GameObject.Find("ball"), new Vector3(0, 0, 0), transform.rotation);//找尋球體名稱並新增克隆球體初始位置為(0,0,0)          
            Destroy(collision.gameObject); //刪除碰撞到的物件
        }
    }
    
}
