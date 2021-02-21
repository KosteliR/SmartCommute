using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    private int flag = 0;

    public void changeToOK(string oktxt)
    {
        if (GetComponentInChildren<Text>().text == "Car" && flag == 0)
        {
            flag = 1;
            Text txt = transform.Find("CarTxt").GetComponent<Text>();
            txt.text = oktxt;
        }
    }

    public void changeToCar(string cartxt)
    {
        if (GetComponentInChildren<Text>().text == "OK" && flag == 0)
        {
            Text txt = transform.Find("CarTxt").GetComponent<Text>();
            txt.text = cartxt;
        }
        else if (flag == 1)
        {
            flag = 0;
        }
    }
}
