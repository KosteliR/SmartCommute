using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public LineRenderer line;
    public GameObject player;
    private Vector3 v;
    private NavMeshPath path;
    private Boolean foundpath;
    public GameObject goal;
    public GameObject goalImg;
    public GameObject notRoad;
    public GameObject notRoadImg;
    public GameObject canvas;
   // public Image goalImg;
    private Vector3 goal_pos;
    private int count = 0;

    void Start()
    {
        line.startWidth = 10.0f;
        line.endWidth = 10.0f;
        line.positionCount = 0;
        path = new NavMeshPath();
        //line.alignment = LineAlignment.TransformZ;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (!IsPointerOverUIObject())
                {
                    goal_pos = hit.point;
                    v = player.transform.position;
                    //this.transform.position = v;
                    foundpath = NavMesh.CalculatePath(v, hit.point, NavMesh.AllAreas, path);
                    if(!(hit.transform.tag == "road"))
                    {
                        notRoad.transform.position = hit.point;
                        Instantiate(notRoadImg, (hit.point + new Vector3(0, 5, 0)), notRoadImg.transform.rotation);
                        GameObject[] xs = GameObject.FindGameObjectsWithTag("x");
                        foreach(GameObject x in xs)
                        {
                            Destroy(x, 0.3f);
                        }

                    }
                }
            }
            if (foundpath)
            {
                count += 1;
                goal.transform.position = goal_pos;
                goal.SetActive(true);
                goalImg.transform.position = FindObjectOfType<Canvas>().transform.position;
                Image img = goalImg.GetComponent<Image>();
                img.transform.position = goal_pos + new Vector3(0,10.0f,5.0f);
                img.transform.eulerAngles = new Vector3(90, 0, 0); 
                goalImg.SetActive(true);
                line.positionCount = path.corners.Length;
                line.SetPosition(0, v);
                for (int i = 1; i < path.corners.Length; i++)
                {
                    Vector3 pospoint = new Vector3(path.corners[i].x, path.corners[i].y, path.corners[i].z);
                    line.SetPosition(i, pospoint);
                }
            }
        }
    }

    //When Touching UI
    private bool IsPointerOverUIObject()
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);
        return results.Count > 0;
    }

    public void deletePath(NavMeshPath new_path)
    {
        path = new_path;
        foundpath = false;
    }
}

