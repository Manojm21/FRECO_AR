using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class linkmanager: MonoBehaviour
{
       public void openlinkedin()
    {
        Application.OpenURL("http://freco.great-site.net/food_item.php?s_id=3&f_id=10");
    }
    public void openinsta()
    {
        Application.OpenURL("http://freco.great-site.net/food_item.php?s_id=2&f_id=16");
    }
    public void opengithub()
    {
        Application.OpenURL("http://freco.great-site.net/food_item.php?s_id=2&f_id=8");
    }
     public void openbiriyani()
    {
        Application.OpenURL("http://freco.great-site.net/food_item.php?s_id=4&f_id=59");
    }
    public void openscanner()
    {
        Application.OpenURL("http://freco.great-site.net/?i=1");

    }

}