using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OptionGenerator : MonoBehaviour
{
    //Create a List of new Dropdown options
    
    //This is the Dropdown
    

    void Start()
    {
        List<string> m_DropOptions = new List<string>();
        m_DropOptions.Add("1998");
        m_DropOptions.Add("2020");
        //Fetch the Dropdown GameObject the script is attached to
        var m_Dropdown = transform.GetComponent<Dropdown>();
        //Clear the old options of the Dropdown menu
        m_Dropdown.options.Clear();
        //Add the options created in the List above
        foreach (var item in m_DropOptions)
        {
            m_Dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
    }
}
