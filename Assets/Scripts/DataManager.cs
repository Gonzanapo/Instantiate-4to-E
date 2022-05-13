using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Text txtNum;
    public Text txtUserName;
    

    public void ShowName()
    {
        Debug.Log("Hola " + txtUserName.text);
    }
    public void ShowNumDouble()
    {
        Debug.Log(int.Parse(txtNum.text) * 2);
    }

}
