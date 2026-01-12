using UnityEngine;

public class InfoWindowController : MonoBehaviour
{
    public GameObject infoCanvas; // Сюди покладемо наше вікно

    public void ToggleWindow()
    {
        // Якщо увімкнено - вимкне, якщо вимкнено - увімкне
        bool isActive = infoCanvas.activeSelf;
        infoCanvas.SetActive(!isActive);
    }
}