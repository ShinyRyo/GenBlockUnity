using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeArea : MonoBehaviour
{
    public int max_z; //フィールドの縦幅。5以上の奇数にすること。
    public int max_x; //フィールドの横幅。5以上の奇数にすること。
    int z; //フィールド配列の縦の要素番号
    int x; //フィールド配列の横の要素番号
    int r; //乱数の値
    Object wall; //壁オブジェクト
    GameObject wallgo; //壁のゲームオブジェクト
    public int[,] field;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int[,] field = new int[max_z, max_x]; //フィールド（0が通路で、1が壁。）
        wall = Resources.Load("Wall"); //壁オブジェクトを読み込む。

        //上下の外壁（1）の生成
        for (x = 0; x < max_x; x++) //フィールドの横幅の分だけループする。
        {
            for (z = 0; z < max_z; z++) //フィールドの縦幅の分だけループする。
            {
                field[z, x] = 1;
            }
        }

        //壁の配置
        for (z = 0; z < max_z; z = z + 1) //フィールドの縦幅の分だけループする。
        {
            for (x = 0; x < max_x; x = x + 1) //フィールドの横幅の分だけループする。
            {
                if (field[z, x] == 0) //通路なら
                {
                    //何も配置しない。
                }
                else if (field[z, x] == 1) //壁なら
                {
                    Instantiate(wall, new Vector3(5.0f * x, 5.0f, 5.0f * z), Quaternion.identity); //壁を配置する。
                }
            }
        }
    }
}
