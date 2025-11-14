using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public InputField nameInputField;
    [SerializeField] GameObject cubePrefab;
    public void JoinRoom()
    {
        SceneManager.LoadScene("Room Scene");
    }
    public void SpwanCube()
    {
        Instantiate(cubePrefab, transform);
    }
}
