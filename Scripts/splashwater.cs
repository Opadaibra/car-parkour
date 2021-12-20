using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class splashwater : MonoBehaviour
{
    public GameObject Drippoint;
    private void OnTriggerEnter(Collider other)
    {
        Vector3 target = other.transform.position;
        GameObject ob =Instantiate(Drippoint, target, Quaternion.identity);
        Destroy(ob, 1f);
    }
}
