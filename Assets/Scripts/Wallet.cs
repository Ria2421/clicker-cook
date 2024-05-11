//-------------------------------------
// 所持金に関する処理 [Wallet.cs]
// Author:Nakamoto Kenta
// Data:2024/05/11
// Updata:2024/05/11
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    //=============
    // フィールド
    //=============
    /// <summary>
    /// 所持金 (桁数が足りなくなることを考慮し、BigIntで宣言)
    /// </summary>
    public BigInteger money;

    /// <summary>
    /// 金額表示テキスト
    /// </summary>
    [SerializeField] private Text walletText;

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
        // 金額をテキストに反映 (小数点以下は切り捨て)
        walletText.text = money.ToString("C0");
    }
}