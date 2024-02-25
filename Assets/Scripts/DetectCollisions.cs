using UnityEngine;

// Para detectar colisiones, necesitamos Colliders y que al menos un Game Object implicado tenga Rigidbody
public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
