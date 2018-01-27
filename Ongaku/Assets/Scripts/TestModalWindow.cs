using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TestModalWindow : MonoBehaviour {
    private ModalPanel modalPanel;
    private DisplayManager displayManager;

    private UnityAction myYesAction;
    private UnityAction myNoAction;
    private UnityAction myCancelAction;
    private UnityAction myLastAction;

    private void Awake()
    {
        modalPanel = ModalPanel.Instance();
        displayManager = DisplayManager.Instance();

        myYesAction = new UnityAction(TestYesFunction);
        myNoAction = new UnityAction(TestNoFunction);
        myCancelAction = new UnityAction(TestCancelFunction);
        myCancelAction = new UnityAction(TestCancelFunction);
    }

    //Send to the Modal Panel to set up the Buttons and Functions to call
    public void TestYNCL()
    {
        modalPanel.Choice("Would you like a poke in the eye?\nNo", myYesAction, myNoAction, myCancelAction, myLastAction);
    }


    void TestYesFunction()
    {
        displayManager.DisplayMessage("YES!");
    }

    void TestNoFunction()
    {
        displayManager.DisplayMessage("NO!");
    }

    void TestCancelFunction()
    {
        displayManager.DisplayMessage("CANCEL!");
    }

    void TestLastFunction()
    {
        displayManager.DisplayMessage("LAST!");
    }
}
