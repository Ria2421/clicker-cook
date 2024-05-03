//-------------------------------------
// 羊に関する処理 [Sheep.cs]
// Author:Nakamoto Kenta
// Data:2024/04/01
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    //=============
    // フィールド
    //=============

    /// <summary>
    /// 羊のレンダラー情報
    /// </summary>
    [SerializeField] private SpriteRenderer sheepRenderer;

    /// <summary>
    /// 毛無の羊画像
    /// </summary>
    [SerializeField] private Sprite cutSheepSprite;

    //===========
    // メソッド
    //===========

    /// <summary>
    /// 初期処理
    /// </summary>
    void Start()
    {
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    void Update()
    {
    }

    /// <summary>
    /// 刈り取り処理
    /// </summary>
    private void Shaving()
    {
        sheepRenderer.sprite = cutSheepSprite;
    }

    /// <summary>
    /// マウスが上に乗った時
    /// </summary>
    private void OnMouseOver()
    {
        // 左クリックが押されていない時は何にもしない
        if (Input.GetMouseButton(0) == false) return;

        // 刈り取り
        Shaving();
    }
}
