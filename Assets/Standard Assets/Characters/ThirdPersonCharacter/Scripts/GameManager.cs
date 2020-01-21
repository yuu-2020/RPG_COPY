using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool clear;
    public Text textGameClear;
    public Text textGameNotClear;
    public static int life;
    private float count = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        clear = false;
        textGameClear.enabled = false;
        textGameNotClear.enabled = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && life==3)
        {
            textGameClear.enabled = true; 
        }
        if(collision.gameObject.tag == "Player" && life < 3)
        {
            textGameNotClear.enabled = true;
            Invoke("kesu",2);    
         }
    }
    void kesu()
    {
        textGameNotClear.enabled = false;
    }
}
