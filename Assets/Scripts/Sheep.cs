//-------------------------------------
// �r�Ɋւ��鏈�� [Sheep.cs]
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
    // �t�B�[���h
    //=============
    /// <summary>
    /// �r�̃����_���[���
    /// </summary>
    [SerializeField] private SpriteRenderer sheepRenderer;

    /// <summary>
    /// �ŏ��̗r�̉摜
    /// </summary>
    private Sprite defaultSprite;

    /// <summary>
    /// �і��̗r�摜
    /// </summary>
    [SerializeField] private Sprite cutSheepSprite;

    /// <summary>
    /// �r�уv���n�u
    /// </summary>
    [SerializeField] private Wool woolPrefab;

    /// <summary>
    /// �r�̐��������ʒu (Y���W)
    /// </summary>
    private float initialYpos = 0;

    /// <summary>
    /// �ړ����x
    /// </summary>
    private float moveSpeed;

    //----------------------------
    // �萔

    /// <summary>
    /// ���������ʒu (X���W)
    /// </summary>
    private const int InitialXpos = 5;

    /// <summary>
    /// ���������ʒu (Y���W)
    /// </summary>
    private const float LowerLimitYpos = -0.3f;

    /// <summary>
    /// ��������ʒu (Y���W)
    /// </summary>
    private const float UpperLimitYpos = 1.9f;

    /// <summary>
    /// �����ړ����x
    /// </summary>
    private const float LowerLimitSpeed = 1.0f;

    /// <summary>
    /// ����ړ����x
    /// </summary>
    private const float UpperLimitSpeed = 2.0f;

    //===========
    // ���\�b�h
    //===========
    /// <summary>
    /// ��������
    /// </summary>
    void Start()
    {
        defaultSprite = sheepRenderer.sprite;
        Initialize();
    }

    /// <summary>
    /// ����������
    /// </summary>
    private void Initialize()
    {
        sheepRenderer.sprite = defaultSprite;
        initialYpos = LowerLimitYpos + Random.Range(0f, UpperLimitYpos);// Y���̐������W�������_���ŎZ�o
        transform.position = new Vector3(InitialXpos, initialYpos, 0);  // �����ʒu���Z�b�g
        moveSpeed = -Random.Range(LowerLimitSpeed, UpperLimitSpeed);    // �ړ����x���Z�b�g
    }

    /// <summary>
    /// �X�V����
    /// </summary>
    void Update()
    {
        transform.position += new Vector3(moveSpeed, 0) * Time.deltaTime;
    }

    /// <summary>
    /// �����菈��
    /// </summary>
    private void Shaving()
    {
        // �摜�̐؂�ւ�
        sheepRenderer.sprite = cutSheepSprite;

        // �r�щ摜�̐���
        var wool = Instantiate(woolPrefab, transform.position, transform.rotation);
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
