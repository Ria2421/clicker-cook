//-------------------------------------
// �������Ɋւ��鏈�� [Wallet.cs]
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
    // �t�B�[���h
    //=============
    /// <summary>
    /// ������ (����������Ȃ��Ȃ邱�Ƃ��l�����ABigInt�Ő錾)
    /// </summary>
    public BigInteger money;

    /// <summary>
    /// ���z�\���e�L�X�g
    /// </summary>
    [SerializeField] private Text walletText;

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
        // ���z���e�L�X�g�ɔ��f (�����_�ȉ��͐؂�̂�)
        walletText.text = money.ToString("C0");
    }
}