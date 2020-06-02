
using UnityEngine;

public class Mainn : MonoBehaviour
{
    public Web Web;

    public static Mainn Instance;//because it s static, i can access it anytime, from anywhere

    void Start()
    {
        Instance = this;
        Web=GetComponent<Web>();
    }

  

}
