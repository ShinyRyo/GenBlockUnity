using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBox : MonoBehaviour
{
    // Start is called before the first frame update
    public Object wall;
    int z; //フィールド配列の縦の要素番号
    int x; //フィールド配列の横の要素番号
    float seconds;

    void Start()
    {//スタートしたらブロックが一つ落ちる
        Instantiate(wall, new Vector3(5.0f * x, 5.0f, 5.0f * z), Quaternion.identity);
        InvokeRepeating("AutoGen", 0f, 1f);
        //Invoke("Hoge", 5);
        seconds += Time.deltaTime;
        if (seconds >= 5)
        {
            seconds = 0;
            Debug.Log("5秒後に実行された");
        }
        GameObject[] answers = GameObject.FindGameObjectsWithTag("answer");
        foreach (GameObject answer in answers) 
        {
            // 消す！
            Destroy(answer);
        }
    }

    // Update is called once per frame
    void Update()
    {//スペースを押したら5X5の範囲に物を並べる。Y座標は3f。

        /*
        if (Input.GetButtonUp("Jump"))
        {

            //Instantiate(wall, new Vector3(Random.Range(-5f, 5f), 50.0f, Random.Range(-5f, 5f)), Quaternion.identity); //壁を配置する。
        }
        //画面をクリックしたらブロックを削除
        if(Input.GetMouseButton(0))
        {
            */
            /*
            Debug.Log("reset");
            GameObject dewall = GameObject.Find("Wall(Clone)");
            Destroy(dewall);*//*
        }
        */

    }

    void AutoGen()
    {
        Instantiate(this.wall, new Vector3(Random.Range(-15f, 15f), transform.position.y, Random.Range(-15f, 15f)), transform.rotation);
    }

    /*
    void Hoge()
    {
        Debug.Log("3秒後に実行された");
        GameObject[] answers = GameObject.FindGameObjectsWithTag("answer");
        foreach (GameObject answer in answers) 
        {
            // 消す！
            Destroy(answer);
        }
    }*/
}
