using UnityEngine;
using UnityEngine.Networking; // Для роботи з мережею
using TMPro;
using System.Collections;

public class APIManager : MonoBehaviour
{
    [Header("Куди виводити текст")]
    public TextMeshProUGUI resultText;

    // При натисканні кнопки
    public void GetCatFact()
    {
        // Запускаємо процес завантаження
        StartCoroutine(FetchData());
    }

    IEnumerator FetchData()
    {
        resultText.text = "Завантаження...";

        // Адреса сервера (API)
        string url = "https://catfact.ninja/fact";

        // Веб-запит
        using (UnityWebRequest request = UnityWebRequest.Get(url))
        {
            // Чекаємо, поки сервер відповість
            yield return request.SendWebRequest();

            // Перевіряємо на помилки
            if (request.result != UnityWebRequest.Result.Success)
            {
                resultText.text = "Помилка: " + request.error;
            }
            else
            {
                // Отримали відповідь
                string jsonResponse = request.downloadHandler.text;

                // Розшифровуємо JSON у наш клас
                CatFactData data = JsonUtility.FromJson<CatFactData>(jsonResponse);

                // Виводимо тільки текст факту
                resultText.text = data.fact;
            }
        }
    }
}

// Клас-обгортка, щоб Unity зрозуміла структуру JSON
[System.Serializable]
public class CatFactData
{
    public string fact;
    public int length;
}