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
    public void FindObj() //Ŭ���� ������Ʈ ã��
    {
        Obj = GameObject.Find(CubeName); //ť�� �̸��� select ���Ͽ� ���� Ŭ������ ����
        ChangeScale();
    }

    public void ChangeScale() //������ ui ������Ʈ�� ���� ����
    {
        objX = Obj.gameObject.transform.localScale.x;
        objZ = Obj.gameObject.transform.localScale.z;

        ObjName.text = CubeName;

        CubeX.text = objX.ToString();
        CubeZ.text = objZ.ToString();
    }

    public void ObjChangeScale() //������Ʈ ũ�� ����
    {
        objX = float.Parse(CubeX.text);
        objZ = float.Parse(CubeZ.text);

        //Debug.Log(objX+ "     " + objZ);

        Obj.gameObject.transform.localScale = new Vector3(objX, Obj.transform.localScale.y, objZ);
    }
}
