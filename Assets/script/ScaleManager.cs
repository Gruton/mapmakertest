using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMPro;
using UnityEngine;

public class ScaleManager : MonoBehaviour
{

    public string CubeName;
    public GameObject Obj;
    public float objX;
    public float objZ;
    public TMP_Text ObjName;
    public TMP_InputField CubeX;
    public TMP_InputField CubeZ;
    //GameObject objName = GameObject.Find("Name");
    public void FindObj() //클릭한 오브젝트 찾기
    {
        Obj = GameObject.Find(CubeName); //큐브 이름은 select 파일에 변경 클래스가 있음
        ChangeScale();
    }

    public void ChangeScale() //오른쪽 ui 오브젝트에 따라 변경
    {
        objX = Obj.gameObject.transform.localScale.x;
        objZ = Obj.gameObject.transform.localScale.z;

        ObjName.text = CubeName;

        CubeX.text = objX.ToString();
        CubeZ.text = objZ.ToString();
    }

    public void ObjChangeScale() //오브젝트 크기 변경
    {
        objX = float.Parse(CubeX.text);
        objZ = float.Parse(CubeZ.text);

        //Debug.Log(objX+ "     " + objZ);

        Obj.gameObject.transform.localScale = new Vector3(objX, Obj.transform.localScale.y, objZ);
    }
}
