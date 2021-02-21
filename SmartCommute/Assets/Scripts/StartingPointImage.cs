using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartingPointImage : MonoBehaviour
{
   // public GameObject StartingPoint;
    private StartingPointMarker carscript;
    private WifiHotSpots wf;

    // Start is called before the first frame update
    void Start()
    {
        carscript = FindObjectOfType<StartingPointMarker>();
        wf = FindObjectOfType<WifiHotSpots>();
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            carscript.set2dmarker(transform.position);
        }
        catch
        {
            wf.set2dmarker(transform.position);
        }
        
        //StartingPointImg.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    }
}
