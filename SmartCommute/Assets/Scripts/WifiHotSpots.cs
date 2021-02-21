using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WifiHotSpots : MonoBehaviour
{
    public GameObject wfHotSpots;
    public GameObject player;
    public GameObject startingpoint;
    public GameObject StartingPointImg;
    public GameObject goalImg;
    public GameObject agent;
    public Canvas canvas;
    private Image img;

    void Start()
    {
        wfHotSpots.SetActive(false);
    }

    public void enableWifiHotSpots()
    {
        wfHotSpots.SetActive(true);
    }

    public void disableWifiHotSpots()
    {
        wfHotSpots.SetActive(false);
    }

    public void pedestrianmode()
    {
        goalImg.SetActive(false);
        agent.GetComponent<LineRenderer>().positionCount = 0;
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

    public void set2dmarker(Vector3 position)
    {
        img.transform.SetParent(canvas.transform, false);
        img.transform.position = position;
    }
}
