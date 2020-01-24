using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class SelectButton : MonoBehaviour
{
    SelectWeapon weapon = new SelectWeapon();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
	{
        if (this.gameObject.name == "Button_1")
		{
            weapon.isButton_1 = true;
        }

        if (this.gameObject.name == "Button_2")
        {
            weapon.isButton_2 = true;
        }

        if (this.gameObject.name == "Button_3")
        {
            weapon.isButton_3 = true;
        }

    }
}
