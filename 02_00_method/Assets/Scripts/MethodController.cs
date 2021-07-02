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
        // SetupItem();

        // for (int i = 0; i < cubeList.Count; i++) {
        //     XAlignment(i, cubeList[i]);
        // }

        GameObject g1 =  CreateObject(PrimitiveType.Cube);
        g1.transform.position = new Vector3(1, 1, 1);

        GameObject g2 =  CreateObject(PrimitiveType.Sphere);
        g2.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        GameObject g3 =  CreateObject(PrimitiveType.Sphere);
        g3.transform.position = new Vector3(-1, -1, -1);
        g3.GetComponent<Renderer>().material.color = Color.blue;

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

    /// <summary>
    /// 引数として渡されたprimitiveTypeをもとに
    /// gameobjectを生成して返す
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    GameObject CreateObject(PrimitiveType type) {
        return GameObject.CreatePrimitive(type);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
