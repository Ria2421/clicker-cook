//-------------------------------------
// �r�Ɋւ��鏈�� [Sheep.cs]
// Author:Nakamoto Kenta
// Data:2024/04/01
// ------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour
{
    //=============
    // �t�B�[���h
    //=============

    /// <summary>
    /// �r�̃����_���[���
    /// </summary>
    [SerializeField] private SpriteRenderer sheepRenderer;

    /// <summary>
    /// �і��̗r�摜
    /// </summary>
    [SerializeField] private Sprite cutSheepSprite;

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
    /// �����菈��
    /// </summary>
    private void Shaving()
    {
        sheepRenderer.sprite = cutSheepSprite;
    }

    /// <summary>
    /// �}�E�X����ɏ������
    /// </summary>
    private void OnMouseOver()
    {
        // ���N���b�N��������Ă��Ȃ����͉��ɂ����Ȃ�
        if (Input.GetMouseButton(0) == false) return;

        // ������
        Shaving();
    }
}
