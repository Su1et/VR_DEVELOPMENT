using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("Гравець врізався в перешкоду!");

            if (_renderer != null)
            {
                _renderer.material.color = Color.red;
            }
        }
        else if (other.CompareTag("Bonus"))
        {
            Debug.Log("Гравець зібрав бонус!");
            Destroy(other);
        }
        else
        {
            Debug.Log("Зіткнення з " + other.name);
        }
    }
}