using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RoomScene : MonoBehaviour
{
    
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private TextMeshProUGUI playernameText;
    [SerializeField] private Sprite voiceOn, voiceOff;
    [SerializeField] private Button voiceButton;
    public LobbyScene lobbyScene;
    private bool voiceoff = true;
    public float horizontalRange = 2f;    
    public float verticalRange = 1f, speed = 100;      
    private Vector3 spawnPos;
    private void Start()
    {
        playernameText.text = lobbyScene.playerNameInput.text;
        Debug.Log("lobbyScene.playerNameInput.text");
        
    }
    void Update()
    {
        
        
        Vector3 randomOffset = transform.right * Random.Range(-horizontalRange, horizontalRange) +
                               transform.up * Random.Range(-verticalRange, verticalRange);
        spawnPos = Vector3.zero + randomOffset;
        cubePrefab.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    public void SpwanCube()
    {
        Instantiate(cubePrefab, spawnPos, Quaternion.identity);
        
       
    }
    public void VoiceOnOff()
    {
        if (voiceoff)
        {
            Debug.Log("Microphone On");
            voiceButton.image.sprite = voiceOn;
            voiceoff = false;
        }
        else
        {
            Debug.Log("Microphone Off");
            voiceButton.image.sprite = voiceOff;
            voiceoff = true;
        }

    }
   
}
