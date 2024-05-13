using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinController : MonoBehaviour
{
    public InputField nameInputField; // 사용자 이름을 입력하는 InputField
    public Button joinButton; // Join 버튼

    private void Start()
    {
        joinButton.onClick.AddListener(OnJoinButtonClick);
    }

    public void OnJoinButtonClick()
    {
        string playerName = nameInputField.text;

        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            GameManager.instance.SetPlayerName(playerName);
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("2~10 사이 글자수로 입력하세요.");
        }

    }
}
