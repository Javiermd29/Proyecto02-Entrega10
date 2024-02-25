using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f; // Límite superior
    private float bottomBound = -10f; // Límite inferior

    private void Update()
    {
        // La comida sale por la parte superior
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        // Los animales salen por la parte inferior
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log("GAME OVER");
            Time.timeScale = 0; // Congelamos el tiempo
        }
    }
}
