using UnityEngine;
using UnityEngine.UI;

public class StartingPointMarker : MonoBehaviour
{
    public Button car;
    public GameObject player;
    public GameObject startingpoint;
    public GameObject StartingPointImg;
    public Camera VerticalCamera;
    public Camera PlayerCamera;
    public Canvas canvas;
    private Image img;
    private int Flag;
    
    public void selectroutemode()
    {
        Flag = 0;
        if (car.GetComponentInChildren<Text>().text == "OK" && Flag == 0)
        {
            Flag = 1;
            Vector3 pos = new Vector3();
            pos.x = player.transform.position.x;
            pos.y = 0.5f;
            pos.z = player.transform.position.z;
            startingpoint.transform.position = pos;
            startingpoint.SetActive(true);
            StartingPointImg.transform.position = FindObjectOfType<Canvas>().transform.position;
            img = StartingPointImg.GetComponent<Image>();
            StartingPointImg.SetActive(true);
            player.SetActive(false);
            pos.y = 1.1f;
            player.transform.position = pos;
        }
        else if(car.GetComponentInChildren<Text>().text == "Car" && Flag == 0)
        {
            Flag = 1;
            player.SetActive(true);
        }
    }

    public void set2dmarker(Vector3 position)
    {
        img.transform.SetParent(canvas.transform, false);
        img.transform.position = position;
    }
}
