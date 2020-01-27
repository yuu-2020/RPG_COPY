using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    ChangeEquip equip = new ChangeEquip();

    public bool debug = false;

    // Start is called before the first frame update
    void Start()
    {
        equip.isButton_1 = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick(int num)
    {
        switch (num)
        {
            case 0:
                equip.isButton_1 = true;
                debug = true;
                //Debug.Log(equip.isButton_1);
                break;
            case 1:
                equip.isButton_2 = true;
                //Debug.Log(equip.isButton_2);
                debug = false;
                break;
            case 2:
                equip.isButton_3 = true;
                //Debug.Log(equip.isButton_3);
                debug = true;
                break;
            default:
                break;
        }
    }
}
