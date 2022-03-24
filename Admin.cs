using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCube
{
    //class Admin:Person
    //{
    //    public FileHandler managerfile = new FileHandler();

    //    ArrayList managerList = new ArrayList();

    //    public ArrayList ManagerList { get; private set; }

    //    public void DisplayAllmanagers()
    //    {
    //        InputOutputHandler.DisplayAllManager(this.managerList);
    //    }

    //    public void RegisterNewmanager()
    //    {
    //        Manager newmanager = InputOutputHandler.GetManagerInfoFromUser();
    //        managerList.Add(newmanager);
    //    }

    //    public void SearchManagerInfobyCNIC()
    //    {
    //        Manager manager = new Manager();
    //        string cnic = InputOutputHandler.getManagerCNIC();
    //        bool managerfound = false;
    //        for (int index = 0; index < managerList.Count; index++)
    //        {
    //            manager = managerList[index] as Manager;
    //            if (manager.CNIC == cnic)
    //            {
    //                managerfound = true;
    //                break;
    //            }
    //        }
    //        if (managerfound)
    //            InputOutputHandler.displayManagerInfo(manager);
    //        else
    //        {
    //            manager.CNIC = "not found";
    //            InputOutputHandler.displayManagerInfo(manager);
    //        }
    //    }

    //    public void SearchmanagerInfobyName()
    //    {
    //        Manager manager = new Manager();
    //        string name = InputOutputHandler.getManagerName();
    //        bool managerfound = false;
    //        int indexofmanager = -1;
    //        for (int index = 0; index < managerList.Count; index++)
    //        {
    //            manager = managerList[index] as Manager;
    //            if (manager.Name == name)
    //            {
    //                managerfound = true;
    //                indexofmanager = index;
    //                break;
    //            }
    //        }
    //        if (managerfound)
    //            InputOutputHandler.displayManagerInfo(manager);
    //        else
    //        {
    //            manager.Name = "not found";
    //            InputOutputHandler.displayManagerInfo(manager);
    //        }
    //    }

    //    public void EditmanagerInfobyCNIC(bool edit)//Getting bool if user wants to edit or delete
    //    {
    //        Manager manager = new Manager();
    //        string cnic = InputOutputHandler.getManagerCNIC();
    //        bool managerfound = false;
    //        int indexofmanager = -1;
    //        for (int index = 0; index < managerList.Count; index++)
    //        {
    //            manager = managerList[index] as Manager;
    //            if (manager.CNIC == cnic)
    //            {
    //                managerfound = true;
    //                indexofmanager = index;
    //                break;
    //            }
    //        }
    //        if (managerfound && edit)//If user selects to edit and the index is found in the AraryList then user will be taken to editmanager Function
    //            InputOutputHandler.EditManager(manager);
    //        else if (!edit && managerfound)//If he wish to delete the manager will be deleted from the record
    //            managerList.Remove(indexofmanager);
    //        else if (!managerfound)
    //        {
    //            manager.CNIC = "not found";
    //            InputOutputHandler.EditManager(manager);
    //        }
    //    }


    //    public void EditManagerInfobyName(bool edit)
    //    {
    //        Manager manager = new Manager();
    //        string name = InputOutputHandler.getManagerName();
    //        bool managerfound = false;
    //        int indexofmanager = -1;
    //        for (int index = 0; index < managerList.Count; index++)
    //        {
    //            manager = managerList[index] as Manager;
    //            if (manager.Name == name)
    //            {
    //                managerfound = true;
    //                indexofmanager = index;
    //                break;
    //            }
    //        }
    //        if (managerfound && edit)
    //            InputOutputHandler.EditManager(manager);
    //        else if (!edit)
    //            managerList.Remove(indexofmanager);
    //        else if (!managerfound)
    //        {
    //            manager.Name = "not found";
    //            InputOutputHandler.EditManager(manager);
    //        }
    //    }

    //    void ExitApplication()
    //    {
    //        managerfile.ManagerList = this.ManagerList;
    //        managerfile.writeback();
    //    }
    //}
}
