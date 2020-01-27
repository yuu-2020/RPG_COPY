using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEquip : MonoBehaviour
{

    ButtonManager buttonManager = new ButtonManager();

    [SerializeField]
    private GameObject[] weapons;

    //ChangeButton button = new ChangeButton();


    // Start is called before the first frame update
    void Start()
    {
        weapons[0].SetActive(false);
        weapons[1].SetActive(false);
        weapons[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        Debug.Log("1" + isButton_1);
        Debug.Log("2" + isButton_2);
        Debug.Log("3" + isButton_3);
        */

        //Debug.Log("debug:" + button.debug);

        if (buttonManager.isButtonProperty_1)
		{
            weapons[0].SetActive(true);
            weapons[1].SetActive(false);
            weapons[2].SetActive(false);
        }

        if (buttonManager.isButtonProperty_2)
		{
            weapons[0].SetActive(false);
            weapons[1].SetActive(true);
            weapons[2].SetActive(false);
        }

        if (buttonManager.isButtonProperty_3)
		{
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(true);
        }
    }
}
