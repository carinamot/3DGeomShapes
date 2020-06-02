using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    public Text popUptext;
    public Button PopUpButton;
    public Text textButton;

    private void Start()
    {
     
    }

  
    public void PopUpText()
    {
        popUptext.text = "Cubul este patrulaterul cu laturile egle.".ToString();
        PopUpButton.interactable = false;
        textButton.text = " ".ToString();
    }
    // Update is called once per frame
    void Update()
    {
        

    }

    
}
