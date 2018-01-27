using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class mousetouch: MonoBehaviour {

    private ModalPanel modalPanel;
    private UnityAction myYesAction;
    private UnityAction myNoAction;
    private UnityAction myCancelAction;
    private UnityAction myLastAction;

   
    void Start()
    {
        modalPanel = ModalPanel.Instance();

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
                    modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
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


}
