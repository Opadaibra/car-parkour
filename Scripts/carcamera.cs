
using UnityEngine;

public class carcamera: MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField]  private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float rotationspeed;
    GameObject Carp;
  
    private void FixedUpdate()
    {
        
        HandleTranslation();
        HandleRotation();
    }
    private void HandleTranslation()
    {
        var targetposition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetposition, speed * Time.deltaTime);
    }
    private void HandleRotation()
    {
        var directon = target.position - transform.position;
        var rotation = Quaternion.LookRotation(directon, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationspeed * Time.deltaTime); 
    }


}
