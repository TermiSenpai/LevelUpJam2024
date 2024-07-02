using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidad de movimiento del jugador
    public GameObject bulletPrefab;  // Prefab de la bala
    public float bulletSpeed = 10f;  // Velocidad de la bala

    void Update()
    {
        // Movimiento del jugador
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0f).normalized;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // Disparo al hacer clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Vector3 shootDirection = (mousePosition - transform.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = shootDirection * bulletSpeed;

        // Destruir la bala después de un tiempo para evitar fugas de memoria
        Destroy(bullet, 2f);
    }
}
