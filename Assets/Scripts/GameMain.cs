//-------------------------------------
// メイン処理 [GameMain.cs]
// Author:Nakamoto Kenta
// Data:2024/05/11
// Updata:2024/05/11
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    //=============
    // フィールド
    //=============
    /// <summary>
    /// 売却ボタン
    /// </summary>
    [SerializeField] private Button SellButton;

    /// <summary>
    /// 所持金
    /// </summary>
    [SerializeField] private Wallet wallet;

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
    /// 売却処理
    /// </summary>
    public void SellAllWool()
    {
        var wools = FindObjectsOfType<Wool>();   // 現在画面にある全てのWoolオブジェクトを取得
        foreach (var wool in wools)
        {   // 取得数分だけ所持金を加算
            wallet.money += 100; //TODO 本当は羊毛毎に金額を変えたい
            Destroy(wool.gameObject);
        }
    }
}
