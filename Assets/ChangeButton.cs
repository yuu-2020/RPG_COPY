using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    ButtonManager buttonManager = new ButtonManager();

    // Start is called before the first frame update
    void Start()
    {
        buttonManager.isButtonProperty_1 = true;
        buttonManager.isButtonProperty_2 = false;
        buttonManager.isButtonProperty_3 = false;
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
                buttonManager.isButtonProperty_1 = true;
                buttonManager.isButtonProperty_2 = false;
                buttonManager.isButtonProperty_3 = false;
                break;
            case 1:
                buttonManager.isButtonProperty_1 = false;
                buttonManager.isButtonProperty_2 = true;
                buttonManager.isButtonProperty_3 = false;
                break;
            case 2:
                buttonManager.isButtonProperty_1 = false;
                buttonManager.isButtonProperty_2 = false;
                buttonManager.isButtonProperty_3 = true;
                break;
            default:
                break;
        }
    }
}
