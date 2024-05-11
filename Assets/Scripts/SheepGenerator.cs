//-------------------------------------
// 羊生成処理 [SheepGenerator.cs]
// Author:Nakamoto Kenta
// Data:2024/05/11
// Updata:2024/05/11
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepGenerator : MonoBehaviour
{
    //=============
    // フィールド
    //=============
    /// <summary>
    /// 生成する羊のプレハブ
    /// </summary>
    [SerializeField] private Sheep sheepPrefab;

    //===========
    // メソッド
    //===========
    /// <summary>
    /// 羊生成処理
    /// </summary>
    public void CreateSheep()
    {
        var sheep = Instantiate(sheepPrefab);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            CreateSheep();
        }
    }
}