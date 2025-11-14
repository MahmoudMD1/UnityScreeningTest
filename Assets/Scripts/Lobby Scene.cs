using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyScene : MonoBehaviour
{

    public TMP_InputField playerNameInput;
    public static string playerName;

    public void JoinRoom()
    {
        playerName = playerNameInput.text;
        if (!string.IsNullOrEmpty(playerName))
        {
            SceneManager.LoadScene("Room Scene");
            //playernameText.text = $"Connected as {playerName}";
            Debug.Log($"Player {playerName} joined room.");
        }
        else
        {
            Debug.LogWarning("Player name is empty.");
        }
        
    }
}
