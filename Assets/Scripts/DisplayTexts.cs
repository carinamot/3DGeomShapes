using UnityEngine;
using TMPro;

public class DisplayTexts : MonoBehaviour
{
    public TextMeshProUGUI textBox;

    void Update()
    {
        textBox.text= "Jocul este alcătuit din 2 nivele, primul cu un grad mediu de dificultate, iar al doilea cu un grad mai mare de ificultate. Cu ajutorul cubului, va trebui sa ocolesti obstacolele pentru a ajunge la finalul jocului. Cubul va putea fi dirijat prin intermediul tastelor A(in acest caz cubul se va deplasa spre dreapta) si D in acest caz cubul se va deplasa spre stanga). Va trebui sa eviti sa atingi obstacolele si sa te incadrezi pe pista de joc, altfel, jocul se va restarta! Poti parasi jocul prin intermediul butonului 'EXIT'. ";
    }


}
