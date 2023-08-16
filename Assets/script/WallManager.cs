using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WallManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool selected = false;
    public int thisCubeNum;
    float y;
    public SpawnManager spawnManager;
    private void Start() //������ ���� �������� �ٴ� �հ� ��������� y�� �缳�� ���ִ°� �Ű� �Ƚᵵ ��
    {
        y = transform.localScale.y / 2;
        transform.position = new Vector3(this.gameObject.transform.position.x, y, this.gameObject.transform.position.z);
        Debug.Log(thisCubeNum);
    }
    void OnMouseDrag() // ������Ʈ �巡�׷� ��ġ �ű�� �̺�Ʈ
    {
        float distance = Camera.main.WorldToScreenPoint(transform.position).z;

        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        objPos.y = y;
        transform.position = objPos;

    }

    private void OnMouseDown()
    {
        //Debug.Log(this.gameObject.name);
    }





    /*void OnMouseDrag()
    {
        Debug.Log("�巡�� ��!!");
        Vector3 mousePosition
        = new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.y);
        //���콺 ��ǥ�� ��ũ�� �� ����� �ٲٰ� �� ��ü�� ��ġ�� ������ �ش�.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }*/

    /*public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
 distance, Input.mousePosition.y);
        transform.position = mousePosition;
    }*/
}
