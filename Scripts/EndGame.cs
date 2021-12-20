using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject Endparticl;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
     
        if(other.tag =="Player")
        {
            Debug.Log("Trigged");
            GameObject ob=Instantiate(Endparticl, other.transform.position, Quaternion.identity);
            Destroy(ob, 1.5f);
            Invoke("NextScean", 3f); 
        }
    }
    void NextScean()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
}
