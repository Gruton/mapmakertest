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
    private void Start() //프리팹 스폰 시켯을때 바닥 뚫고 가지말라고 y축 재설정 해주는거 신경 안써도 됨
    {
        y = transform.localScale.y / 2;
        transform.position = new Vector3(this.gameObject.transform.position.x, y, this.gameObject.transform.position.z);
        Debug.Log(thisCubeNum);
    }
    void OnMouseDrag() // 오브젝트 드래그로 위치 옮기는 이벤트
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
        Debug.Log("드래그 중!!");
        Vector3 mousePosition
        = new Vector3(Input.mousePosition.x, 0f, Input.mousePosition.y);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }*/

    /*public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x,
 distance, Input.mousePosition.y);
        transform.position = mousePosition;
    }*/
}
