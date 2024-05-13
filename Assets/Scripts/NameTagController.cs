using System;
using UnityEngine;
using UnityEngine.UI;

public class NameTagController : MonoBehaviour
{
    public Transform player;
    public Vector2 offset; // 인스펙터 창에서 950, 630으로 넣어봄

    public Text nameText;

    private void Start()
    {
        nameText.text = GameManager.instance.playerName;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, transform.position.z);
    }
}
