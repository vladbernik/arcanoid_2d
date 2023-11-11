using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    public GameObject Header; // Ссылка на объект вашей заставки

    void Start()
    {
        // Показать заставку при запуске
        Header.SetActive(true);
    }

    // Пример: скрыть заставку по нажатию кнопки
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Измените это условие в соответствии с вашими потребностями
        {
            // Скрыть заставку
            Header.SetActive(false);
        }
    }
}
