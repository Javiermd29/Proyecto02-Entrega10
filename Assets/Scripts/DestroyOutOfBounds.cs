using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f; // Límite superior
    private float bottomBound = -10f; // Límite inferior

    private GameManager gameManager;
    private UIManager uiManager;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIManager>();
    }

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
            uiManager.ShowGameOverPanel(gameManager.animalsFed);
            Time.timeScale = 0; // Congelamos el tiempo
        }
    }
}
