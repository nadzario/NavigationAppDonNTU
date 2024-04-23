using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownMenu : MonoBehaviour
{
    public GameObject Campus1_Floor_DropDownMenu;
    public GameObject Campus1_Floor_Object;
    public Image Campus1_Floor;
    public Sprite Campus1_Floor0;
	public GameObject Campus1_Floor0_Graph;
    public Sprite Campus1_Floor1;
	public GameObject Campus1_Floor1_Graph;
    public Sprite Campus1_Floor2;
	public GameObject Campus1_Floor2_Graph;
    public Sprite Campus1_Floor3;
	public GameObject Campus1_Floor3_Graph;
    public Sprite Campus1_Floor4;
	public GameObject Campus1_Floor4_Graph;

    public GameObject Campus2_Floor_DropDownMenu;
    public GameObject Campus2_Floor_Object;
    public Image Campus2_Floor;
    public Sprite Campus2_Floor1;
    public GameObject Campus2_Floor1_Graph;
    public Sprite Campus2_Floor2;
    public GameObject Campus2_Floor2_Graph;
    public Sprite Campus2_Floor3;
    public GameObject Campus2_Floor3_Graph;
    public Sprite Campus2_Floor4;
    public GameObject Campus2_Floor4_Graph;

    public GameObject Campus3_Floor_DropDownMenu;
    public GameObject Campus3_Floor_Object;
    public Image Campus3_Floor;
    public Sprite Campus3_Floor1;
    public GameObject Campus3_Floor1_Graph;
    public Sprite Campus3_Floor2;
    public GameObject Campus3_Floor2_Graph;
    public Sprite Campus3_Floor3;
    public GameObject Campus3_Floor3_Graph;
    public Sprite Campus3_Floor4;
    public GameObject Campus3_Floor4_Graph;

    public int CampusValue;
    public int CampusFloorValue;

    public void InputMenuCampus(int value) 
	{
        CampusValue = value;
    }
    public void InputMenuFloor(int value)
    {
        CampusFloorValue = value;
    }


    void Update() 
    {
        switch (CampusValue)
        {
            case 0:
                {
                    Campus3_Floor_Object.SetActive(false);
                    Campus3_Floor_DropDownMenu.SetActive(false);
                    Campus2_Floor_Object.SetActive(false);
                    Campus2_Floor_DropDownMenu.SetActive(false);
                    Campus1_Floor_Object.SetActive(true);
                    Campus1_Floor_DropDownMenu.SetActive(true);

                    switch (CampusFloorValue)
                    {
                        case 0:
                            {
                                Campus1_Floor.sprite = Campus1_Floor0;
                                Campus1_Floor0_Graph.SetActive(true);
                                Campus1_Floor1_Graph.SetActive(false);
                                Campus1_Floor2_Graph.SetActive(false);
                                Campus1_Floor3_Graph.SetActive(false);
                                Campus1_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 1:
                            {
                                Campus1_Floor.sprite = Campus1_Floor1;
                                Campus1_Floor0_Graph.SetActive(false);
                                Campus1_Floor1_Graph.SetActive(true);
                                Campus1_Floor2_Graph.SetActive(false);
                                Campus1_Floor3_Graph.SetActive(false);
                                Campus1_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 2:
                            {
                                Campus1_Floor.sprite = Campus1_Floor2;
                                Campus1_Floor0_Graph.SetActive(false);
                                Campus1_Floor1_Graph.SetActive(false);
                                Campus1_Floor2_Graph.SetActive(true);
                                Campus1_Floor3_Graph.SetActive(false);
                                Campus1_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 3:
                            {
                                Campus1_Floor.sprite = Campus1_Floor3;
                                Campus1_Floor0_Graph.SetActive(false);
                                Campus1_Floor1_Graph.SetActive(false);
                                Campus1_Floor2_Graph.SetActive(false);
                                Campus1_Floor3_Graph.SetActive(true);
                                Campus1_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 4:
                            {
                                Campus1_Floor.sprite = Campus1_Floor4;
                                Campus1_Floor0_Graph.SetActive(false);
                                Campus1_Floor1_Graph.SetActive(false);
                                Campus1_Floor2_Graph.SetActive(false);
                                Campus1_Floor3_Graph.SetActive(false);
                                Campus1_Floor4_Graph.SetActive(true);
                                break;
                            }
                        
                    }
                    break;
                }


            case 1:
                {
                    Campus1_Floor_Object.SetActive(false);
                    Campus1_Floor_DropDownMenu.SetActive(false);
                    Campus2_Floor_Object.SetActive(true);
                    Campus2_Floor_DropDownMenu.SetActive(true);
                    Campus3_Floor_Object.SetActive(false);
                    Campus3_Floor_DropDownMenu.SetActive(false);

                    switch (CampusFloorValue) {

                        case 0:
                        {
                        Campus2_Floor.sprite = Campus2_Floor1;
                        Campus2_Floor1_Graph.SetActive(true);
                        Campus2_Floor2_Graph.SetActive(false);
                        Campus2_Floor3_Graph.SetActive(false);
                        Campus2_Floor4_Graph.SetActive(false);
                        break;
                        }
                        case 1:
                        {
                        Campus2_Floor.sprite = Campus2_Floor2;
                        Campus2_Floor1_Graph.SetActive(false);
                        Campus2_Floor2_Graph.SetActive(true);
                        Campus2_Floor3_Graph.SetActive(false);
                        Campus2_Floor4_Graph.SetActive(false);
                        break;
                        }
                        case 2:
                        {
                        Campus2_Floor.sprite = Campus2_Floor3;
                        Campus2_Floor1_Graph.SetActive(false);
                        Campus2_Floor2_Graph.SetActive(false);
                        Campus2_Floor3_Graph.SetActive(true);
                        Campus2_Floor4_Graph.SetActive(false);
                        break;
                        }
                        case 3:
                        {
                        Campus2_Floor.sprite = Campus2_Floor4;
                        Campus2_Floor1_Graph.SetActive(false);
                        Campus2_Floor2_Graph.SetActive(false);
                        Campus2_Floor3_Graph.SetActive(false);
                        Campus2_Floor4_Graph.SetActive(true);
                        break;
                        }
                        
                    }
                    break;
                }
            case 2:
                {
                    Campus1_Floor_Object.SetActive(false);
                    Campus1_Floor_DropDownMenu.SetActive(false);
                    Campus2_Floor_Object.SetActive(false);
                    Campus2_Floor_DropDownMenu.SetActive(false);
                    Campus3_Floor_Object.SetActive(true);
                    Campus3_Floor_DropDownMenu.SetActive(true);
                   

                    switch (CampusFloorValue)
                    {

                        case 0:
                            {
                                Campus3_Floor.sprite = Campus3_Floor1;
                                Campus3_Floor1_Graph.SetActive(true);
                                Campus3_Floor2_Graph.SetActive(false);
                                Campus3_Floor3_Graph.SetActive(false);
                                Campus3_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 1:
                            {
                                Campus3_Floor.sprite = Campus3_Floor2;
                                Campus3_Floor1_Graph.SetActive(false);
                                Campus3_Floor2_Graph.SetActive(true);
                                Campus3_Floor3_Graph.SetActive(false);
                                Campus3_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 2:
                            {
                                Campus3_Floor.sprite = Campus3_Floor3;
                                Campus3_Floor1_Graph.SetActive(false);
                                Campus3_Floor2_Graph.SetActive(false);
                                Campus3_Floor3_Graph.SetActive(true);
                                Campus3_Floor4_Graph.SetActive(false);
                                break;
                            }
                        case 3:
                            {
                                Campus3_Floor.sprite = Campus3_Floor4;
                                Campus3_Floor1_Graph.SetActive(false);
                                Campus3_Floor2_Graph.SetActive(false);
                                Campus3_Floor3_Graph.SetActive(false);
                                Campus3_Floor4_Graph.SetActive(true);
                                break;
                            }

                    }
                    break;
                }
        }
    }
}
