//-------------------------------------
// 羊毛に関する処理 [Wool.cs]
// Author:Nakamoto Kenta
// Data:2024/05/10
// Updata:2024/05/10
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wool : MonoBehaviour
{
    //=============
    // フィールド
    //=============

    /// <summary>
    /// 羊毛の物理演算用変数
    /// </summary>
    [SerializeField] private Rigidbody2D rigidbody2D;

    //===========
    // メソッド
    //===========

    /// <summary>
    /// 初期処理
    /// </summary>
    void Start()
    {
        // 生成時に上方向にランダムに散る力を与える
        rigidbody2D.AddForce(Quaternion.Euler(0, 0, Random.Range(-15.0f, 15.0f)) * Vector2.up * 4, ForceMode2D.Impulse);

        // 生成時のサイズをばらけさせる
        transform.localScale = Vector3.one * Random.Range(0.4f, 1.5f);
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    void Update()
    {
        if (transform.position.y < -5)
        {   // 画面の下に行ったときに消す
            Destroy(gameObject);
        }
    }
}
