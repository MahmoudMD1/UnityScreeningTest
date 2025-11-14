using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static System.Net.Mime.MediaTypeNames;

public class UIController : MonoBehaviour
{
    public TMP_InputField playerName;
    
   
    public void JoinRoom()
    {
        //
        SceneManager.LoadScene("Room Scene");
        //playernameText.text = $"Connected as {playerName}";
        Debug.Log($"Player {playerName} joined room.");
        
    }

}
