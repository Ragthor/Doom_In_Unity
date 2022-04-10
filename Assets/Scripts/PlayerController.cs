using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(playerMove))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento = 5f;
    public float VelocidadDeMovimiento { get { return velocidadMovimiento; } }

    [SerializeField] private float mouseSensivility = 2f;
    public float SensivilidadDeMouse { get { return mouseSensivility; } }
}
