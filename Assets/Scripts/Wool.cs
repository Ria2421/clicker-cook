//-------------------------------------
// �r�тɊւ��鏈�� [Wool.cs]
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
    // �t�B�[���h
    //=============

    /// <summary>
    /// �r�т̕������Z�p�ϐ�
    /// </summary>
    [SerializeField] private Rigidbody2D rigidbody2D;

    //===========
    // ���\�b�h
    //===========

    /// <summary>
    /// ��������
    /// </summary>
    void Start()
    {
        // �������ɏ�����Ƀ����_���ɎU��͂�^����
        rigidbody2D.AddForce(Quaternion.Euler(0, 0, Random.Range(-15.0f, 15.0f)) * Vector2.up * 4, ForceMode2D.Impulse);

        // �������̃T�C�Y���΂炯������
        transform.localScale = Vector3.one * Random.Range(0.4f, 1.5f);
    }

    /// <summary>
    /// �X�V����
    /// </summary>
    void Update()
    {
        if (transform.position.y < -5)
        {   // ��ʂ̉��ɍs�����Ƃ��ɏ���
            Destroy(gameObject);
        }
    }
}
