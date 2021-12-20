using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform cameratarget;
    [SerializeField] private Vector3 offset;
    public float smoothspeed = 5f;
    float rotationspeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dpos = cameratarget.position + offset;
        Vector3 spos = Vector3.Lerp(transform.position, dpos, smoothspeed * Time.deltaTime);
        transform.position = spos +offset;
        transform.rotation = Quaternion.Euler(90f, target.eulerAngles.y, 0f);
        transform.LookAt(target.position);
    }
    private void HandleTranslation()
    {
        var targetposition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, targetposition, smoothspeed * Time.deltaTime);
    }
    private void HandleRotation()
    {
        var directon = target.position - transform.position;
        var rotation = Quaternion.LookRotation(directon, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, smoothspeed * Time.deltaTime);
    }
}
