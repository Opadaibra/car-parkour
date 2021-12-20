using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gamemanger : MonoBehaviour
{
  
    public carcontroller rr;
    public GameObject needl;
    private float startpos =220f, endpos=-49f;
    private float disiredpos;
    public Text kph;
    public float carspeed;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        carspeed = rr.kph  ;
        updatnadle();
    }

   private void updatnadle()
   {
       //kph.text = carspeed.ToString();
       disiredpos = startpos - endpos;
       float temp = carspeed / 180f;
       needl.transform.eulerAngles = new Vector3(0,0, (startpos - temp*disiredpos));
       
   }
}
