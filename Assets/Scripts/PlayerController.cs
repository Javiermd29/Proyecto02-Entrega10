using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;
    private float horizontalInput;
    private float xRange = 15f;

    [SerializeField] private GameObject foodPrefab;
    
    private void Update()
    {
        // Movimiento
        Movement();
        
        // Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFood();
        }
        
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        
        PlayerInBounds();
    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        // Límite por la izquierda
        if (pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        
        // Límite por la derecha
        if (pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
        
    }

    private void ShootFood()
    {
        Instantiate(foodPrefab, transform.position, Quaternion.identity);
    }
}
