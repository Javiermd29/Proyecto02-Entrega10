using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;

    public void Update()
    {
        // Movimiento hacia adelante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
