using UnityEngine;
using UnityEngine.UI;

public class InteractiveButtons : MonoBehaviour
{
    public Button car;
    public Button pedestrian;
    public Button bus;

    public void disablePedestrian()
    {
        if(car.GetComponentInChildren<Text>().text == "Car")
        {
            pedestrian.gameObject.GetComponent<Button>().interactable = true;
            bus.gameObject.GetComponent<Button>().interactable = true;
        }
        else if(car.GetComponentInChildren<Text>().text == "OK")
        {
            pedestrian.gameObject.GetComponent<Button>().interactable = false;
            bus.gameObject.GetComponent<Button>().interactable = false;
        }
    }
}
