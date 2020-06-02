
using UnityEngine;

public class SliderMenu : MonoBehaviour
{
    public GameObject Menu;

        public void ShowHide()
    {
        if (Menu != null)
        {
            Animator anim = Menu.GetComponent<Animator>();
            if (anim != null)
            {
                bool isOpen = anim.GetBool("Show");
                anim.SetBool("Show", !isOpen);
            }
        }
    }
}
