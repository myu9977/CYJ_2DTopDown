using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinController : MonoBehaviour
{
    private NameTagController nameTagController;

    public InputField nameInputField; // 사용자 이름을 입력하는 InputField
    public Button joinButton; // Join 버튼

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
            nameTagController.SetPlayerName(playerName); // 이름표로 쓰기 위해 넘겨줌
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("2~10 사이 글자수로 입력하세요.");
        }

    }
}
