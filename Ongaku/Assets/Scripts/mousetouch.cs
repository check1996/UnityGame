using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mousetouch: MonoBehaviour {

    //private TestModalWindow tester;
    //private GameObject world;

    void Start()
    {
       // world = 
        //tester = new TestModalWindow();
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //Select Stage
                if (hit.transform.name == "Water")
                {
                    //tester.TestYNCL();
                    Debug.Log("yeah yeah yeah");
                }
                if (hit.transform.name == "Wood")
                {
                    //tester.TestYNCL();
                    Debug.Log("yeah yeah yeah");
                }
                if (hit.transform.name == "Iron")
                {
                    //tester.TestYNCL();
                    Debug.Log("yeah yeah yeah");
                }
                if (hit.transform.name == "Earth")
                {
                    //tester.TestYNCL();
                    Debug.Log("yeah yeah yeah");
                }
                if (hit.transform.name == "Fire")
                {
                    //tester.TestYNCL();
                    Debug.Log("yeah yeah yeah");
                }
            }
        }

    }
}
