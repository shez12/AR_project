using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class read_info : MonoBehaviour
{
    public List<string> read_data = new List<string>();
    Vector3 pos_1;
    Vector3 pos_2;
    // Start is called before the first frame update
    void Start()
    {
       pos_1 = GameObject.Find("TMS-Head-transformed-081621").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        var matrix1 = GameObject.Find("TMS-Head-transformed-081621").transform.localRotation;
        pos_2= GameObject.Find("TMS-Head-transformed-081621").transform.position;
        Vector3 pos_3= pos_2- pos_1;
        
        read_data.Add(matrix1[0].ToString());
        read_data.Add(matrix1[1].ToString());
        read_data.Add(matrix1[2].ToString());
        read_data.Add(pos_3[0].ToString());
        read_data.Add(pos_3[1].ToString());
        read_data.Add(pos_3[2].ToString());
        //Debug.Log(read_data.Count());

        // add function here
        read_data.Clear();
    }
}
