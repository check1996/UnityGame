using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class mousetouch: MonoBehaviour {

    private ModalPanel modalPanel;

    private static GameObject sceneCam;
    public float strength = 0.5f;

    private UnityAction myYesAction;
    private UnityAction myNoAction;
    private UnityAction myCancelAction;
    private UnityAction myLastAction;

   
    void Start()
    {
        modalPanel = ModalPanel.Instance();

        sceneCam = GameObject.Find("Main Camera");

        myYesAction = new UnityAction(playNote1);
        myNoAction = new UnityAction(playNote2);
        myCancelAction = new UnityAction(playNote3);
        myLastAction = new UnityAction(playNote4);

    }

    // Update is called once per frame
    void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Water")
                {
                    moveCamPos(2, 1, -13);
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Wood")
                {
                    moveCamPos(14, 1, -4);
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Iron")
                {
                    moveCamPos(-1, 1, 6);
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Earth")
                {
                    moveCamPos(-7, 1, -4);
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Fire")
                {
                    moveCamPos(7, 1, 6);
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
            }
        }

    }

    //Move to seperate class
    public void playNote1()
    {
        Debug.Log("Played first note");
    }
    public void playNote2()
    {
        Debug.Log("Played second note");

    }
    public void playNote3()
    {
        Debug.Log("Played third note");

    }
    public void playNote4()
    {
        Debug.Log("Played fourth note");

    }


    public void moveCamPos(float x, float y, float z)
    {
        Debug.Log("Null not here");
        Vector3 cameraPosition = new Vector3(x, y, z);
        sceneCam.transform.position = cameraPosition;
            //Vector3.Lerp(transform.position, cameraPosition, strength);
    }


}
