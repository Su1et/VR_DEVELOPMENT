using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // стрілки вліво-вправо
        float moveZ = Input.GetAxis("Vertical"); // стрілки вгору-вниз

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
    
}
