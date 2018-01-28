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
    private UnityAction waterYesAction;
    private UnityAction waterNoAction;
    private UnityAction waterCancelAction;
    private UnityAction waterLastAction;
    private UnityAction woodYesAction;
    private UnityAction woodNoAction;
    private UnityAction woodCancelAction;
    private UnityAction woodLastAction;
    private UnityAction ironYesAction;
    private UnityAction ironNoAction;
    private UnityAction ironCancelAction;
    private UnityAction ironLastAction;
    private UnityAction earthYesAction;
    private UnityAction earthNoAction;
    private UnityAction earthCancelAction;
    private UnityAction earthLastAction;
    private UnityAction fireYesAction;
    private UnityAction fireNoAction;
    private UnityAction fireCancelAction;
    private UnityAction fireLastAction;
    private AudioClip watersound1;
    private AudioClip watersound2;
    private AudioClip watersound3;
    private AudioClip watersound4;
    private AudioClip woodsound1;
    private AudioClip woodsound2;
    private AudioClip woodsound3;
    private AudioClip woodsound4;
    private AudioClip ironsound1;
    private AudioClip ironsound2;
    private AudioClip ironsound3;
    private AudioClip ironsound4;
    private AudioClip earthsound1;
    private AudioClip earthsound2;
    private AudioClip earthsound3;
    private AudioClip earthsound4;
    private AudioClip firesound1;
    private AudioClip firesound2;
    private AudioClip firesound3;
    private AudioClip firesound4;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }


    private static GameObject sceneCam;
    public float strength = 0.5f;



   
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
        //iron
        ironsoundpicker();
        ironactioncreated();
        //earth
        earthsoundpicker();
        earthactioncreated();
        //fire
        firesoundpicker();
        fireactioncreated();

        gameObject.AddComponent<AudioSource>();
        //source.playOnAwake = false;

        sceneCam = GameObject.Find("Main Camera");



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
                    modalPanel.Choice("Flavor text", waterYesAction, waterNoAction, waterCancelAction, waterLastAction);
                }
                if (hit.transform.name == "Wood")
                {
                    moveCamPos(14, 1, -4);
                    modalPanel.Choice("Flavor text", woodYesAction, woodNoAction, woodCancelAction, woodLastAction);
                }
                if (hit.transform.name == "Iron")
                {
                    moveCamPos(-1, 1, 6);
                    modalPanel.Choice("Flavor text", ironYesAction, ironNoAction, ironCancelAction, ironLastAction);
                }
                if (hit.transform.name == "Earth")
                {
                    moveCamPos(-7, 1, -4);
                    modalPanel.Choice("Flavor text", earthYesAction, earthNoAction, earthCancelAction, earthLastAction);
                }
                if (hit.transform.name == "Fire")
                {
                    moveCamPos(7, 1, 6);
                    modalPanel.Choice("Flavor text", fireYesAction, fireNoAction, fireCancelAction, fireLastAction);
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
    //wood end

    //iron part
    public void ironplayNote1()
    {
        source.PlayOneShot(ironsound1);
    }
    public void ironplayNote2()
    {
        source.PlayOneShot(ironsound2);

    }
    public void ironplayNote3()
    {
        source.PlayOneShot(ironsound3);

    }
    public void ironplayNote4()
    {
        source.PlayOneShot(ironsound4);

    }
    public void ironsoundpicker()
    {
        int counter = 0;
        int number = 0;
        System.Random random = new System.Random();
        while (counter < 4)
        {
            if (counter == 0)
            {
                number = random.Next(0, iron.Count);
                ironsound1 = iron[number];
                iron.RemoveAt(number);
                counter++;
            }
            if (counter == 1)
            {
                number = random.Next(0, iron.Count);
                ironsound2 = iron[number];
                iron.RemoveAt(number);
                counter++;
            }
            if (counter == 2)
            {
                number = random.Next(0, iron.Count);
                ironsound3 = iron[number];
                iron.RemoveAt(number);
                counter++;
            }
            if (counter == 3)
            {
                number = random.Next(0, iron.Count);
                ironsound4 = iron[number];
                iron.RemoveAt(number);
                counter++;
            }
        }

    }
    public void ironactioncreated()
    {
        ironYesAction = new UnityAction(ironplayNote1);
        ironNoAction = new UnityAction(ironplayNote2);
        ironCancelAction = new UnityAction(ironplayNote3);
        ironLastAction = new UnityAction(ironplayNote4);
    }
    // iron end

    //earth part
    public void earthplayNote1()
    {
        source.PlayOneShot(earthsound1);
    }
    public void earthplayNote2()
    {
        source.PlayOneShot(earthsound2);

    }
    public void earthplayNote3()
    {
        source.PlayOneShot(earthsound3);

    }
    public void earthplayNote4()
    {
        source.PlayOneShot(earthsound4);

    }
    public void earthsoundpicker()
    {
        int counter = 0;
        int number = 0;
        System.Random random = new System.Random();
        while (counter < 4)
        {
            if (counter == 0)
            {
                number = random.Next(0, earth.Count);
                earthsound1 = earth[number];
                earth.RemoveAt(number);
                counter++;
            }
            if (counter == 1)
            {
                number = random.Next(0, earth.Count);
                earthsound2 = earth[number];
                earth.RemoveAt(number);
                counter++;
            }
            if (counter == 2)
            {
                number = random.Next(0, earth.Count);
                earthsound3 = earth[number];
                earth.RemoveAt(number);
                counter++;
            }
            if (counter == 3)
            {
                number = random.Next(0, earth.Count);
                earthsound4 = earth[number];
                earth.RemoveAt(number);
                counter++;
            }
        }

    }
    public void earthactioncreated()
    {
        earthYesAction = new UnityAction(earthplayNote1);
        earthNoAction = new UnityAction(earthplayNote2);
        earthCancelAction = new UnityAction(earthplayNote3);
        earthLastAction = new UnityAction(earthplayNote4);
    }
    // earth end

    // fire part 
    public void fireplayNote1()
    {
        source.PlayOneShot(firesound1);
    }
    public void fireplayNote2()
    {
        source.PlayOneShot(firesound2);

    }
    public void fireplayNote3()
    {
        source.PlayOneShot(firesound3);

    }
    public void fireplayNote4()
    {
        source.PlayOneShot(firesound4);

    }
    public void firesoundpicker()
    {
        int counter = 0;
        int number = 0;
        System.Random random = new System.Random();
        while (counter < 4)
        {
            if (counter == 0)
            {
                number = random.Next(0, fire.Count);
                firesound1 = fire[number];
                fire.RemoveAt(number);
                counter++;
            }
            if (counter == 1)
            {
                number = random.Next(0, fire.Count);
                firesound2 = fire[number];
                fire.RemoveAt(number);
                counter++;
            }
            if (counter == 2)
            {
                number = random.Next(0, fire.Count);
                firesound3 = fire[number];
                fire.RemoveAt(number);
                counter++;
            }
            if (counter == 3)
            {
                number = random.Next(0, fire.Count);
                firesound4 = fire[number];
                fire.RemoveAt(number);
                counter++;
            }
        }

    }
    public void fireactioncreated()
    {
        fireYesAction = new UnityAction(fireplayNote1);
        fireNoAction = new UnityAction(fireplayNote2);
        fireCancelAction = new UnityAction(fireplayNote3);
        fireLastAction = new UnityAction(fireplayNote4);
    }
     // fire end
    public void moveCamPos(float x, float y, float z)
    {
        Debug.Log("Null not here");
        Vector3 cameraPosition = new Vector3(x, y, z);
        sceneCam.transform.position = cameraPosition;
            //Vector3.Lerp(transform.position, cameraPosition, strength);
    }


}
