using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handtraking : MonoBehaviour
{
    // Start is called before the first frame update
    
    public UDPReceive udpReceive;
    public GameObject[] handpoints;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        print(data);
        string[] points = data.Split(',');

        for ( int i = 0; i < 21; i++)
        {
            float x = 7 - float.Parse(points[i * 3]) / 100;
            float y = float.Parse(points[i * 3+1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;


            handpoints[i].transform.localPosition = new Vector3(x, y, z);




        }
    }
}
