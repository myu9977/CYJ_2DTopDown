using System;
using UnityEngine;
using UnityEngine.UI;

public class NameTagController : MonoBehaviour
{
    public Transform player;
    public Vector2 offset; // �ν����� â���� 950, 630���� �־

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
