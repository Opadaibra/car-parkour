using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameMangerscript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CountDownTime;
    [SerializeField] private GameObject TimeOut;
    Rigidbody x;
   // [SerializeField] private GameObject PlayerCar;
    private float CurrentTime;
    public float startTime = 1;
   
    // Start is called before the first frame update

    private void Start()
    {
       // Instantiate(PlayerCar, transform.position, Quaternion.identity);
        CurrentTime = startTime;       
    }
    private void Update()
    {
        if(CurrentTime >= 0)
             CurrentTime -= Time.deltaTime;
        CountDownTime.text = CurrentTime.ToString("0");
        if(CurrentTime <=0)
        {
            TimeOut.gameObject.SetActive(true);
            Invoke("loadscean", 5f);
        }
       
     
    }
    void loadscean()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame

}
