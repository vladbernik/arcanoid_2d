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
    public TextMeshProUGUI playerListText; // Текстовое поле для отображения списка игроков
    public GameDataScript gameData;
    private string[] topPlayers = new string[5];

    public void UpdatePlayerList()
    {
        // Загрузка лучших результатов из сохранения или другого источника
        // Например, можно использовать PlayerPrefs или базу данных
        string playerName = nameInputField.text;
        // Заглушка: пример данных
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
            Debug.Log("Имя игрока: " + playerName);
        }
        else
        {
            Debug.LogError("InputField не был назначен!");
        }
    }

    public void LoadGameScene()
    {
        Debug.Log("Нажата кнопка Начать");
        SceneManager.LoadScene("SampleScene"); 
    }

    public void ExitGame()
    {
        // Логика выхода из приложения
        Application.Quit(); // ВНИМАНИЕ: Это может не работать во всех случаях
    }
}
