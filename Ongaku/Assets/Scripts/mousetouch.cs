using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class mousetouch: MonoBehaviour {

    private ModalPanel modalPanel;
    private UnityAction waterYesAction;
    private UnityAction waterNoAction;
    private UnityAction waterCancelAction;
    private UnityAction waterLastAction;
    private UnityAction woodYesAction;
    private UnityAction woodNoAction;
    private UnityAction woodCancelAction;
    private UnityAction woodLastAction;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    public AudioClip sound5;
    public AudioClip sound6;
    public AudioClip sound7;
    public AudioClip sound8;
    public AudioClip sound9;
    public AudioClip sound10;
    public AudioClip sound11;
    public AudioClip sound12;
    public AudioClip sound13;
    public AudioClip sound14;
    public AudioClip sound15;
    public AudioClip sound16;
    public AudioClip sound17;
    public AudioClip sound18;
    public AudioClip sound19;
    public AudioClip sound20;
    public AudioClip sound21;
    public AudioClip sound22;
    public AudioClip sound23;
    public AudioClip sound24;
    public AudioClip sound25;
    public AudioClip sound26;
    public AudioClip sound27;
    public AudioClip sound28;
    public AudioClip sound29;
    public AudioClip sound30;
    public AudioClip sound31;
    public AudioClip sound32;
    public AudioClip sound33;
    public AudioClip sound34;
    public AudioClip sound35;
    public AudioClip sound36;
    public AudioClip sound37;
    public AudioClip sound38;
    public AudioClip sound39;
    public AudioClip sound40;
    public AudioClip sound41;
    public AudioClip sound42;
    public AudioClip sound43;
    public AudioClip sound44;
    public AudioClip sound45;
    public AudioClip sound46;
    public AudioClip sound47;
    public AudioClip sound48;
    public AudioClip sound49;
    public AudioClip sound50;
    public AudioClip sound51;
    public AudioClip sound52;
    public AudioClip sound53;
    public AudioClip sound54;
    public AudioClip sound55;
    public AudioClip sound56;
    public AudioClip sound57;
    public AudioClip sound58;
    public AudioClip sound59;
    public AudioClip sound60;
    public AudioClip sound61;
    public AudioClip sound62;
    public AudioClip sound63;
    public AudioClip sound64;
    public AudioClip sound65;
    public AudioClip sound66;
    public AudioClip sound67;
    public AudioClip sound68;
    public AudioClip sound69;
    public AudioClip sound70;
    public AudioClip sound71;
    public AudioClip sound72;
    public AudioClip sound73;
    public AudioClip sound74;
    public AudioClip sound75;
    public AudioClip sound76;
    public AudioClip sound77;
    public AudioClip sound78;
    public AudioClip sound79;
    public AudioClip sound80;
    public List<AudioClip> water;
    public List<AudioClip> wood;
    public List<AudioClip> iron;
    public List<AudioClip> earth;
    public List<AudioClip> fire;
    private AudioClip watersound1;
    private AudioClip watersound2;
    private AudioClip watersound3;
    private AudioClip watersound4;
    private AudioClip woodsound1;
    private AudioClip woodsound2;
    private AudioClip woodsound3;
    private AudioClip woodsound4;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

   
    void Start()
    {
        
        water = new List<AudioClip>(new AudioClip[] { sound1, sound2, sound3, sound4, sound5, sound6, sound7, sound8, sound9,
            sound10, sound11, sound12, sound13, sound14, sound15, sound16});
        wood = new List<AudioClip>(new AudioClip[] { sound17, sound18, sound19, sound20, sound21, sound22, sound23, sound24, sound25,
            sound26, sound27, sound28, sound29, sound30, sound31, sound32});
        iron = new List<AudioClip>(new AudioClip[] { sound33, sound34, sound35, sound36, sound37, sound38, sound39, sound40, sound41,
            sound42, sound43, sound44, sound45, sound46, sound47, sound48});
        earth = new List<AudioClip>(new AudioClip[] { sound49, sound50, sound51, sound52, sound53, sound54, sound55, sound56, sound57,
            sound58, sound59, sound60, sound61, sound62, sound63, sound64});
        fire = new List<AudioClip>(new AudioClip[] { sound65, sound66, sound67, sound68, sound69, sound70, sound71, sound72, sound73,
            sound74, sound75, sound76, sound77, sound78, sound79, sound80});
        modalPanel = ModalPanel.Instance();
        //water
        watersoundpicker();
        wateractioncreated();
        //wood
        woodsoundpicker();
        woodactioncreated();
        gameObject.AddComponent<AudioSource>();
        //source.playOnAwake = false;


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
                    modalPanel.Choice("Flavor text", waterYesAction, waterNoAction, waterCancelAction, waterLastAction);
                }
                if (hit.transform.name == "Wood")
                {
                   modalPanel.Choice("Flavor text", woodYesAction, woodNoAction, woodCancelAction, woodLastAction);
                }
                if (hit.transform.name == "Iron")
                {
                    //modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Earth")
                {
                   // modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
                if (hit.transform.name == "Fire")
                {
                   // modalPanel.Choice("Flavor text", myYesAction, myNoAction, myCancelAction, myLastAction);
                }
            }
        }

    }

    //water part
    public void waterplayNote1()
    {
        source.PlayOneShot(watersound1);
    }
    public void waterplayNote2()
    {
        source.PlayOneShot(watersound2);

    }
    public void waterplayNote3()
    {
        source.PlayOneShot(watersound3);

    }
    public void waterplayNote4()
    {
        source.PlayOneShot(watersound4);

    }
    public void watersoundpicker()
    {
        int counter = 0;
        int number = 0;
        System.Random random = new System.Random();
        while (counter < 4)
        {
            if (counter == 0)
            {
                number = random.Next(0, water.Count);
                watersound1 = water[number];
                water.RemoveAt(number);
                counter++;
            }
            if (counter == 1)
            {
                number = random.Next(0, water.Count);
                watersound2 = water[number];
                water.RemoveAt(number);
                counter++;
            }
            if (counter == 2)
            {
                number = random.Next(0, water.Count);
                watersound3 = water[number];
                water.RemoveAt(number);
                counter++;
            }
            if (counter == 3)
            {
                number = random.Next(0, water.Count);
                watersound4 = water[number];
                water.RemoveAt(number);
                counter++;
            }
        }
               
      
    }
    public void wateractioncreated()
    {
        waterYesAction = new UnityAction(waterplayNote1);
        waterNoAction = new UnityAction(waterplayNote2);
        waterCancelAction = new UnityAction(waterplayNote3);
        waterLastAction = new UnityAction(waterplayNote4);
}
    // waterend

     //wood part
    public void woodplayNote1()
    {
        source.PlayOneShot(woodsound1);
    }
    public void woodplayNote2()
    {
        source.PlayOneShot(woodsound2);

    }
    public void woodplayNote3()
    {
        source.PlayOneShot(woodsound3);

    }
    public void woodplayNote4()
    {
        source.PlayOneShot(woodsound4);

    }
    public void woodsoundpicker()
    {
        int counter = 0;
        int number = 0;
        System.Random random = new System.Random();
        while (counter < 4)
        {
            if (counter == 0)
            {
                number = random.Next(0, wood.Count);
                woodsound1 = wood[number];
                wood.RemoveAt(number);
                counter++;
            }
            if (counter == 1)
            {
                number = random.Next(0, wood.Count);
                woodsound2 = wood[number];
                wood.RemoveAt(number);
                counter++;
            }
            if (counter == 2)
            {
                number = random.Next(0, wood.Count);
                woodsound3 = wood[number];
                wood.RemoveAt(number);
                counter++;
            }
            if (counter == 3)
            {
                number = random.Next(0, wood.Count);
                woodsound4 = wood[number];
                wood.RemoveAt(number);
                counter++;
            }
        }


    }
    public void woodactioncreated()
    {
        woodYesAction = new UnityAction(woodplayNote1);
        woodNoAction = new UnityAction(woodplayNote2);
        woodCancelAction = new UnityAction(woodplayNote3);
        woodLastAction = new UnityAction(woodplayNote4);
    }
}
