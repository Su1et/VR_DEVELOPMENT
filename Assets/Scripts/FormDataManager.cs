using UnityEngine;
using TMPro; // для роботи з текстовими полями

public class FormDataManager : MonoBehaviour
{
    [Header("Поля вводу")]
    public TMP_InputField nameInput;
    public TMP_InputField surnameInput;

    // Ключі, за якими будемо шукати дані в пам'яті
    private string nameKey = "SavedName";
    private string surnameKey = "SavedSurname";

    // Викликаємо при натисканні "Зберегти"
    public void SaveData()
    {
        string currentName = nameInput.text;
        string currentSurname = surnameInput.text;

        // Записуємо в PlayerPrefs
        PlayerPrefs.SetString(nameKey, currentName);
        PlayerPrefs.SetString(surnameKey, currentSurname);
        
        // Зберігаємо фізично на диск
        PlayerPrefs.Save();

        Debug.Log($"Дані збережено: {currentName} {currentSurname}");
    }

    // Ця функція викличеться при натисканні "Завантажити"
    public void LoadData()
    {
        // Перевіряємо, чи є взагалі збережені дані
        if (PlayerPrefs.HasKey(nameKey))
        {
            // Дістаємо дані і вставляємо назад у поля
            nameInput.text = PlayerPrefs.GetString(nameKey);
            surnameInput.text = PlayerPrefs.GetString(surnameKey);
            
            Debug.Log("Дані відновлено!");
        }
        else
        {
            Debug.Log("Збережених даних не знайдено.");
        }
    }
}