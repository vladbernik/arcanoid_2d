using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class StartGame : MonoBehaviour
{
    public GameObject StartCanvas;
    //public GameObject PauseCanvas;
    public TMP_InputField nameInputField;
    public TextMeshProUGUI playerListText; // ��������� ���� ��� ����������� ������ �������
    public GameDataScript gameData;
    private string[] topPlayers = new string[5];

    public void UpdatePlayerList()
    {
        // �������� ������ ����������� �� ���������� ��� ������� ���������
        // ��������, ����� ������������ PlayerPrefs ��� ���� ������
        string playerName = nameInputField.text;
        // ��������: ������ ������
        topPlayers[0] = "Player1 - 1000";
        topPlayers[1] = "Player2 - 900";
        topPlayers[2] = "Player3 - 800";
        topPlayers[3] = "Player4 - 700";
        topPlayers[4] = playerName + " - ????";

        UpdatePlayerListText();
    }

    private void UpdatePlayerListText()
    {
        if (playerListText != null)
        {
            string listText = "Top Players:\n";
            for (int i = 0; i < topPlayers.Length; i++)
            {
                listText += (i + 1) + ". " + topPlayers[i] + gameData.points + "\n";
            }
            playerListText.text = listText;
        }
        else
        {
            Debug.LogWarning("playerListText is null. Make sure to assign the TextMeshProUGUI object in the inspector.");
        }
    }

    public void SavePlayerName()
    {
        if (nameInputField != null)
        {
            string playerName = nameInputField.text;
            Debug.Log("��� ������: " + playerName);
        }
        else
        {
            Debug.LogError("InputField �� ��� ��������!");
        }
    }

    public void LoadGameScene()
    {
        Debug.Log("������ ������ ������");
        SceneManager.LoadScene("SampleScene"); 
    }

    public void ExitGame()
    {
        // ������ ������ �� ����������
        Application.Quit(); // ��������: ��� ����� �� �������� �� ���� �������
    }
}
