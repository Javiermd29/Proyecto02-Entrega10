using UnityEngine;

// Para detectar colisiones, necesitamos Colliders y que al menos un Game Object implicado tenga Rigidbody
public class DetectCollisions : MonoBehaviour
{

    private GameManager gameManager;
    private UIManager uiManager;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!(transform.gameObject.CompareTag("Carrot") && other.transform.gameObject.CompareTag("Carrot")))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManager.animalsFed++;
            gameManager.UpdateAnimalsFed();
        }

    }

}
