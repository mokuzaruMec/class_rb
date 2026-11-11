using UnityEngine;
using System.Collections;
public class juego : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit (Collider other){

        if(other.attachedRigidbody){
            other.attachedRigidbody.AddForce(Vector3.up * 1000);
        }
    }
}
