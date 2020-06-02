using UnityEngine;

public class switchlogin: MonoBehaviour
{
    public GameObject register;
    public GameObject login;
    private bool ok=false;

   public void Switchhh()
    {
        if (!ok)
        {
            register.SetActive(true);
            login.SetActive(false);
            ok = true;
        }
        else
        {
            register.SetActive(false);
            login.SetActive(true);
            ok = false;
        }
       
    }
}
