//-------------------------------------
// �r�������� [SheepGenerator.cs]
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
    // �t�B�[���h
    //=============
    /// <summary>
    /// ��������r�̃v���n�u
    /// </summary>
    [SerializeField] private Sheep sheepPrefab;

    //===========
    // ���\�b�h
    //===========
    /// <summary>
    /// �r��������
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