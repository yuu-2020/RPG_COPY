using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    ChangeEquip equip = new ChangeEquip();

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
                break;
            case 1:
                equip.isButton_2 = true;
                break;
            case 2:
                equip.isButton_3 = true;
                break;
            default:
                break;
        }
    }
}
