using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScript : MonoBehaviour
{
    public GameObject Header; // ������ �� ������ ����� ��������

    void Start()
    {
        // �������� �������� ��� �������
        Header.SetActive(true);
    }

    // ������: ������ �������� �� ������� ������
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // �������� ��� ������� � ������������ � ������ �������������
        {
            // ������ ��������
            Header.SetActive(false);
        }
    }
}
