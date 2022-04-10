using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private PlayerController player;
    private Rigidbody2D rb;
    private Vector2 controlMovimiento;
    private Vector2 mouseMovimiento;
    private Transform cam;

    private void Awake()
    {
        player = GetComponent<PlayerController>();
        rb = GetComponent<Rigidbody2D>();
        cam = GetComponentInChildren<Camera>().transform;
    }

    private void FixedUpdate()
    {
        Move();
    }

    // Movimiento del jugador
    void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        controlMovimiento = new Vector2(moveX / 4, moveY);

        Vector3 moveHorizontal = transform.up * -controlMovimiento.x * Time.deltaTime;
        Vector3 moveVertical = transform.right * controlMovimiento.y * Time.deltaTime;

        rb.velocity = (moveHorizontal + moveVertical) * player.VelocidadDeMovimiento * 20;


        // movimiento camara
        mouseMovimiento = new Vector2(moveX, 0f) * player.SensivilidadDeMouse * 15 * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - mouseMovimiento.x);
        cam.localRotation = Quaternion.Euler(cam.localRotation.eulerAngles + new Vector3(0f, 0f, 0f));
    }

}
