using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    Collider car;
    public Collider carcollider;

    private void Start()
    {
        
    }
    // GameObject car1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            car = other.gameObject.GetComponent<Collider>();
            Invoke("Car", 1f);
        }
    }
    public void Car()
    {
        if(car == null)
        {
            car = carcollider;
        }
        
        car.attachedRigidbody.velocity = Vector3.zero;
        car.transform.root.position = FindObjectOfType<ChicpointScript>().Chickpoint;
        car.transform.root.eulerAngles = FindObjectOfType<ChicpointScript>().ChickpointRotation;
    }


}
