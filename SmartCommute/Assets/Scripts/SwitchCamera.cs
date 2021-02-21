using UnityEngine;
using UnityEngine.UI;

public class SwitchCamera : MonoBehaviour
{
    public Camera vertical_cam;
    public Camera main_cam;
    public Button car;
    private int flag = 0;

    public void SwitchOnVertCam()//Camera camtodisable, Camera camtoenable)//Text txt)
    {
        if (car.GetComponentInChildren<Text>().text == "OK" && flag == 0)
        {
            flag = 1;
            main_cam.gameObject.SetActive(false);
            vertical_cam.gameObject.SetActive(true);
        }
    }

    public void SwitchOnMainCam()
    {
        if (car.GetComponentInChildren<Text>().text == "Car" && flag == 0)
        {
            vertical_cam.gameObject.SetActive(false);
            main_cam.gameObject.SetActive(true);
        }
        else if (flag == 1)
        {
            flag = 0;
        }
    }
    
    public void SwitchOnVerticalCamPedestrian()
    {
        vertical_cam.gameObject.SetActive(true);
        main_cam.gameObject.SetActive(false);
    }
}
