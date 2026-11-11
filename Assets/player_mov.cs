using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PlayerInput))]
public class player_mov : MonoBehaviour
{
    [Header("Ajustes de Movimiento")]
    [SerializeField] public float velocidad = 8f;
    [SerializeField] public float fuerzaSalto = 3f;
    private Rigidbody rb;

    private Vector2 inputMovimiento;

    private InputAction playerActions;
    private InputAction saltar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
        playerActions = InputSystem.actions.FindAction("Move");
        saltar = InputSystem.actions.FindAction("Jump");
    }
/*
    private void Saltando (InputAction.CallbackContext contexto){
        Debug.Log(contexto);
    }
*/

    private void OnTriggerEnter(Collider other){
        velocidad++;
    }

   
    private void FixedUpdate()
    {
        
        
        inputMovimiento = playerActions.ReadValue<Vector2>();
        transform.Translate(new Vector3(inputMovimiento.x, 0, inputMovimiento.y) * Time.deltaTime);

        if(saltar.IsPressed()){
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Force);
        }
    }
}
