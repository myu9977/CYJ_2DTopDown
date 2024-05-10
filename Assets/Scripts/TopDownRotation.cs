using System;
using UnityEngine;

public class TopDownRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnFlip;
    }

    private void OnFlip(Vector2 direction)
    {
        //RotatePlayer(direction);

        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
    
    // 플레이어의 방향을 바꾸는 기능 하나 뿐이므로 다시 메서드를 만들지 않고
    // 바로 OnFlip에서 바꾸도록 하였음.

    /*
    private void RotatePlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
    */

}