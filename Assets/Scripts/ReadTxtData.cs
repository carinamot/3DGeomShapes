using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]

public class ReadTxtData : MonoBehaviour
{
    public static List<string> textArray;

    private bool display;
    private Text textComp;
    public string FileName;

    [SerializeField]
    public int[] rowsToReadFrom;

    private TextAsset textAsset;

  

    void Start()
    {
        textAsset = Resources.Load("txtFiles/" + FileName) as TextAsset;
        textComp = GetComponent<Text>();
        readTxtFile();
    }

    void Update()
    {
        if (display)
        {
            GetComponent<Renderer>().enabled = true;
        }
        else if (!display)
        {
            GetComponent<Renderer>().enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            display = !display;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            display = !display;
        }
    }

    public void readTxtFile()
    {
        textArray = textAsset.text.Split('\n').ToList();
        for(int i = 0; i < rowsToReadFrom.Length; i++)
        {
            if (rowsToReadFrom[0] < 0 || rowsToReadFrom.Length == 0)
            {
                textComp.text = textAsset.text;
            }
            else
            {
                textComp.text += textArray[rowsToReadFrom[i]] + "\n";
            }
        }
    }
}
