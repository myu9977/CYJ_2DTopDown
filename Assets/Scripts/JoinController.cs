using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinController : MonoBehaviour
{
    private NameTagController nameTagController;

    public InputField nameInputField; // ����� �̸��� �Է��ϴ� InputField
    public Button joinButton; // Join ��ư

    private void Start()
    {
        nameTagController = GetComponent<NameTagController>();
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    public void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            nameTagController.SetPlayerName(playerName); // �̸�ǥ�� ���� ���� �Ѱ���
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("2~10 ���� ���ڼ��� �Է��ϼ���.");
        }

    }
}
