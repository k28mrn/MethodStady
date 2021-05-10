using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodController : MonoBehaviour
{
    public GameObject cube;
    public List<GameObject> cubeList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        SetupItem();

        for (int i = 0; i < cubeList.Count; i++) {
            XAlignment(i, cubeList[i]);
        }
    }

    /// <summary>
    /// prefabからgameobjectを複製してlistに格納するメソッド
    /// </summary>
    void SetupItem() {
        for (int i = 0; i < 5; i++) {
            GameObject c = (GameObject)Instantiate(cube);
            cubeList.Add(c);
        }
    }
    
    /// <summary>
    /// gameobjectの整列
    /// </summary>
    /// <param name="x"></param>
    /// <param name="cube"></param>
    void XAlignment(int x, GameObject cube) {
        Vector3 pos = cube.transform.position;
        pos.x = pos.x + x;
        cube.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
