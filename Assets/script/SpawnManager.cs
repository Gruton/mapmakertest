using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Cube;
    public GameManager gameManager;
    public WallManager wallManager;

    public int CubeCount = 0;
    // Start is called before the first frame update
    public void CubeSpawn() //큐브 프리팹 스폰 시키기
    {
        CubeCount = CubeCount + 1;
        wallManager.thisCubeNum = CubeCount;
        GameObject SpawnCube = Instantiate(Cube, transform.position, transform.rotation);
        SpawnCube.name = "Cube" + CubeCount;
        gameManager.Cubes.Add(CubeCount);
    }
}
