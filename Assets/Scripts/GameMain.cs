//-------------------------------------
// ���C������ [GameMain.cs]
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
    // �t�B�[���h
    //=============
    /// <summary>
    /// ���p�{�^��
    /// </summary>
    [SerializeField] private Button SellButton;

    /// <summary>
    /// ������
    /// </summary>
    [SerializeField] private Wallet wallet;

    //===========
    // ���\�b�h
    //===========
    /// <summary>
    /// ��������
    /// </summary>
    void Start()
    {
        
    }

    /// <summary>
    /// �X�V����
    /// </summary>
    void Update()
    {
        
    }

    /// <summary>
    /// ���p����
    /// </summary>
    public void SellAllWool()
    {
        var wools = FindObjectsOfType<Wool>();   // ���݉�ʂɂ���S�Ă�Wool�I�u�W�F�N�g���擾
        foreach (var wool in wools)
        {   // �擾�������������������Z
            wallet.money += 100; //TODO �{���͗r�і��ɋ��z��ς�����
            Destroy(wool.gameObject);
        }
    }
}
