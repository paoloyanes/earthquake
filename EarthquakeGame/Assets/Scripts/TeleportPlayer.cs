using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] 
    GameObject startingLocation01, startingLocation12, startingLocation17;


    // First Floor
    [SerializeField]
    GameObject FirstRightWingFToilet;

    [SerializeField]
    GameObject FirstRightWingMToilet;

    [SerializeField]
    GameObject GCA101A, GCA101B, GCA102, UnamedRoom1, UnamedRoom2, OSDS, CPTClinic, CPTOffice, PumpRoom, GENSETRoom, PFMOStockroom;

    // Second Floor
    [SerializeField]
    GameObject SecondRightWingFToilet, SecondRightWingMToilet, COAOffice, OfficeStaff, AuditStorageFiles, CAUP_CAD_Room, CAUPOffice, USECStockroom, AVR2AClassroom, AVR2BClassroom, DMSTOffice, AVR1AClassroom, SecondLeftWingFToilet, SecondLeftWingMToilet;

    // 1st Test Locations
    Vector3 location01, location12, location17;

    // First Floor
    Vector3 location1, location2, location3, location4, location5, location6, location7, location8, location9, location10, location11, location13, location14;
    // Second Floor
    Vector3 location15, location16, location18, location19, location20, location21, location22, location23, location24, location25, location26, location27, location28, location29;
    static public int teleportedLocation = 0;

    public bool isDone = false;

    // Start is called before the first frame update
    void Start()
    {
        location01 = startingLocation01.transform.position;
        location12 = startingLocation12.transform.position;
        location17 = startingLocation17.transform.position;


        // First Floor
        location1 = FirstRightWingFToilet.transform.position;
        location2 = FirstRightWingMToilet.transform.position;
        location3 = GCA101A.transform.position;
        location4 = GCA101B.transform.position;
        location5 = GCA102.transform.position;
        location6 = UnamedRoom1.transform.position;
        location7 = UnamedRoom2.transform.position;
        location8 = OSDS.transform.position;
        location9 = CPTClinic.transform.position;
        location10 = CPTOffice.transform.position;
        location11 = PumpRoom.transform.position;
        location13 = GENSETRoom.transform.position;
        location14 = PFMOStockroom.transform.position;
    
        // Second Floor
        location15 = SecondRightWingFToilet.transform.position;
        location16 = SecondRightWingMToilet.transform.position;
        location18 = COAOffice.transform.position;
        location19 = OfficeStaff.transform.position;
        location20 = AuditStorageFiles.transform.position;
        location21 = CAUP_CAD_Room.transform.position;
        location22 = CAUPOffice.transform.position;
        location23 = USECStockroom.transform.position;
        location24 = AVR2AClassroom.transform.position;
        location25 = AVR2BClassroom.transform.position;
        location26 = DMSTOffice.transform.position;
        location27 = AVR1AClassroom.transform.position;
        location28 = SecondLeftWingFToilet.transform.position;
        location29 = SecondLeftWingMToilet.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDone)
        {
            if (StateNameController.selectStartingLocationDropdown == 0)
            {
                PlayerStartingLocation(location01); //1F - Classroom 1
            }
            else if (StateNameController.selectStartingLocationDropdown == 1)
            {
                PlayerStartingLocation(location17); //2F - Classroom 2
            }
            else if (StateNameController.selectStartingLocationDropdown == 2)
            {
                PlayerStartingLocation(location12); //3F - GCA 303
            }
            // First Floor ====================================================================
            else if (StateNameController.selectStartingLocationDropdown == 3)
            {
                PlayerStartingLocation(location1); //1F - Right Wing CR F
            }
            else if (StateNameController.selectStartingLocationDropdown == 4)
            {
                PlayerStartingLocation(location2); //1F - Right Wing CR M
            }
            else if (StateNameController.selectStartingLocationDropdown == 5)
            {
                PlayerStartingLocation(location3); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 6)
            {
                PlayerStartingLocation(location4); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 7)
            {
                PlayerStartingLocation(location5); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 8)
            {
                PlayerStartingLocation(location6); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 9)
            {
                PlayerStartingLocation(location7); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 10)
            {
                PlayerStartingLocation(location8); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 11)
            {
                PlayerStartingLocation(location9); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 12)
            {
                PlayerStartingLocation(location10); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 13)
            {
                PlayerStartingLocation(location11); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 14)
            {
                PlayerStartingLocation(location13); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 15)
            {
                PlayerStartingLocation(location14); 
            }

            // Second Floor =============================================================
            else if (StateNameController.selectStartingLocationDropdown == 16)
            {
                PlayerStartingLocation(location15); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 17)
            {
                PlayerStartingLocation(location16); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 18)
            {
                PlayerStartingLocation(location18); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 19)
            {
                PlayerStartingLocation(location19); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 20)
            {
                PlayerStartingLocation(location20); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 21)
            {
                PlayerStartingLocation(location21); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 22)
            {
                PlayerStartingLocation(location22); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 23)
            {
                PlayerStartingLocation(location23); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 24)
            {
                PlayerStartingLocation(location24); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 25)
            {
                PlayerStartingLocation(location25); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 26)
            {
                PlayerStartingLocation(location26); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 27)
            {
                PlayerStartingLocation(location27); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 28)
            {
                PlayerStartingLocation(location28); 
            }
            else if (StateNameController.selectStartingLocationDropdown == 29)
            {
                PlayerStartingLocation(location29); 
            }

            // Third Floor ==============================================================
            else
            {
                PlayerStartingLocation(location01);
            }
            isDone = true;
            
        }
        
    }

    void PlayerStartingLocation(Vector3 location)
    {
        gameObject.transform.position = location;
        Debug.Log(location + " Teleported!");
    }

}
