//-------------------------------------
// 羊に関する処理 [Sheep.cs]
// Author:Nakamoto Kenta
// Data:2024/04/01
// Updata:2024/05/10
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
    /// 最初の羊の画像
    /// </summary>
    private Sprite defaultSprite;

    /// <summary>
    /// 毛無の羊画像
    /// </summary>
    [SerializeField] private Sprite cutSheepSprite;

    /// <summary>
    /// 羊毛プレハブ
    /// </summary>
    [SerializeField] private Wool woolPrefab;

    /// <summary>
    /// 羊の生成初期位置 (Y座標)
    /// </summary>
    private float initialYpos = 0;

    /// <summary>
    /// 移動速度
    /// </summary>
    private float moveSpeed;

    //----------------------------
    // 定数

    /// <summary>
    /// 生成初期位置 (X座標)
    /// </summary>
    private const int InitialXpos = 5;

    /// <summary>
    /// 生成下限位置 (Y座標)
    /// </summary>
    private const float LowerLimitYpos = -0.3f;

    /// <summary>
    /// 生成上限位置 (Y座標)
    /// </summary>
    private const float UpperLimitYpos = 1.9f;

    /// <summary>
    /// 下限移動速度
    /// </summary>
    private const float LowerLimitSpeed = 1.0f;

    /// <summary>
    /// 上限移動速度
    /// </summary>
    private const float UpperLimitSpeed = 2.0f;

    //===========
    // メソッド
    //===========
    /// <summary>
    /// 初期処理
    /// </summary>
    void Start()
    {
        defaultSprite = sheepRenderer.sprite;
        Initialize();
    }

    /// <summary>
    /// 初期化処理
    /// </summary>
    private void Initialize()
    {
        sheepRenderer.sprite = defaultSprite;
        initialYpos = LowerLimitYpos + Random.Range(0f, UpperLimitYpos);// Y軸の生成座標をランダムで算出
        transform.position = new Vector3(InitialXpos, initialYpos, 0);  // 初期位置をセット
        moveSpeed = -Random.Range(LowerLimitSpeed, UpperLimitSpeed);    // 移動速度をセット
    }

    /// <summary>
    /// 更新処理
    /// </summary>
    void Update()
    {
        transform.position += new Vector3(moveSpeed, 0) * Time.deltaTime;
    }

    /// <summary>
    /// 刈り取り処理
    /// </summary>
    private void Shaving()
    {
        // 画像の切り替え
        sheepRenderer.sprite = cutSheepSprite;

        // 羊毛画像の生成
        var wool = Instantiate(woolPrefab, transform.position, transform.rotation);
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
