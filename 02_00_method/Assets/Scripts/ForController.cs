using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject cube;
        int x = 0;
        int y = 0;
        for (int i = 0; i < 100; i += 1) {
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(x, y, 0);
            x += 1;
            if (x == 10) {
                x = 0;
                y += 1;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
