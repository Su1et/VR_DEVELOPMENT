using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed = 50f;

    void Update()
    {
        //Обертання навколо осі Y
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
    
}
