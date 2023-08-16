using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update
    private RaycastHit hit;
    public ScaleManager scaleManager;
    public GameObject sidebar;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) selectObject();

        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.blue);
            
        }
    }

    void selectObject()//오브젝트를 선택 하는 매서드
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.tag == "Obj") {
            sidebar.SetActive(true);
            string objectName = hit.collider.gameObject.name;

            scaleManager.CubeName = objectName;

            scaleManager.FindObj();


            }
            else if (hit.collider.gameObject.tag == "sidebar")
            {
                sidebar.SetActive(true);
            }
            else
            {
                sidebar.SetActive(false);
            }

        }
    }
}
