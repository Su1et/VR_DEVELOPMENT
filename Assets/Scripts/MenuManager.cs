using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour
{
    public GameObject menuCanvas;
    public InputActionProperty showButton; // Кнопка, яку будемо слухати

    void Update()
    {
        // Перевіряємо, чи натиснута кнопка (wasPressedThisFrame)
        if (showButton.action.WasPressedThisFrame())
        {
            // Перемикаємо активність (якщо було увімкнено - вимкне, і навпаки)
            menuCanvas.SetActive(!menuCanvas.activeSelf);
        }
    }
}