using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{


    public float speed = 100.0f;//球速
    public Text Score_text;//顯示分數物件
   

    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;//球體一開始向上
        Score_text = GameObject.Find("Text").GetComponent<Text>();//尋找text物件

       
    }

    // Update is called once per frame
    void Update()
    {

    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)//反射
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {


        
        if (collision.gameObject.name == "racket")//棒反射
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
        
        else if (collision.gameObject.name.Substring(0, 5) == "block")//呼叫函式
        {
            AddScore();
        }
    }
    void AddScore()
    {
        //取得分數字串轉成int，原因是每顆球的腳本每次都會重新刷新一次，為了累加分數則取Score_text.text再轉成int
        int count = int.Parse(Score_text.text);
        count += 10;
        string score= count.ToString();
        Score_text.text = score;
        
        
        speed += 2;//每加一次分數就提升球速
    }
}

