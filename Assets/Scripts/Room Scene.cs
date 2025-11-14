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
    public UIController  uIController;
    private bool voiceoff = true;
    public float horizontalRange = 2f;    // Side to side random range
    public float verticalRange = 1f;      // Up and down random range
    private Vector3 spawnPos;

    // Update is called once per frame
    void Update()
    {
        uIController.playerName.text = playernameText.text;
        Vector3 randomOffset = transform.right * Random.Range(-horizontalRange, horizontalRange) +
                               transform.up * Random.Range(-verticalRange, verticalRange);
        spawnPos = transform.position + randomOffset;
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
