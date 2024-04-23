using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject Campus1_Floor0;
    public Work Campus1_Floor0_G;
    public GameObject Campus1_Floor1;
    public Work Campus1_Floor1_G;
    public GameObject Campus1_Floor2;
    public Work Campus1_Floor2_G;
    public GameObject Campus1_Floor3;
    public Work Campus1_Floor3_G;
    public GameObject Campus1_Floor4;
    public Work Campus1_Floor4_G;

    public GameObject Campus2_Floor1;
    public Work Campus2_Floor1_G;
    public GameObject Campus2_Floor2;
    public Work Campus2_Floor2_G;
    public GameObject Campus2_Floor3;
    public Work Campus2_Floor3_G;
    public GameObject Campus2_Floor4;
    public Work Campus2_Floor4_G;

    public GameObject Campus3_Floor1;
    public Work Campus3_Floor1_G;
    public GameObject Campus3_Floor2;
    public Work Campus3_Floor2_G;
    public GameObject Campus3_Floor3;
    public Work Campus3_Floor3_G;
    public GameObject Campus3_Floor4;
    public Work Campus3_Floor4_G;

    public void ButtonDown() 
    {
        if (Campus1_Floor0.activeInHierarchy)
        {
            Campus1_Floor0_G.Upd();
        }
        else if (Campus1_Floor1.activeInHierarchy)
        {
            Campus1_Floor1_G.Upd();
        }
        else if (Campus1_Floor2.activeInHierarchy)
        {
            Campus1_Floor2_G.Upd();
        }
        else if (Campus1_Floor3.activeInHierarchy)
        {
            Campus1_Floor3_G.Upd();
        }
        else if (Campus1_Floor4.activeInHierarchy)
        {
            Campus1_Floor4_G.Upd();
        }
        else if (Campus2_Floor1.activeInHierarchy)
        {
            Campus2_Floor1_G.Upd();
        }
        else if (Campus2_Floor2.activeInHierarchy)
        {
            Campus2_Floor2_G.Upd();
        }
        else if (Campus2_Floor3.activeInHierarchy)
        {
            Campus2_Floor3_G.Upd();
        }
        else if (Campus2_Floor4.activeInHierarchy)
        {
            Campus2_Floor4_G.Upd();
        }
        else if (Campus3_Floor1.activeInHierarchy)
        {
            Campus3_Floor1_G.Upd();
        }
        else if (Campus3_Floor2.activeInHierarchy)
        {
            Campus3_Floor2_G.Upd();
        }
        else if (Campus3_Floor3.activeInHierarchy)
        {
            Campus3_Floor3_G.Upd();
        }
        else if (Campus3_Floor4.activeInHierarchy)
        {
            Campus3_Floor4_G.Upd();
        }
    }



}
