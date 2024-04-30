using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 5f;
    public float ManaInicial = 100f;
    public float taxaDeDecrementoMana = 1f;
    public float ManaAtual;
    private Rigidbody2D rb;
    public Slider sliderMana;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ManaAtual = ManaInicial;
        AtualizarSliderMana();
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxisRaw("Horizontal") * velocidade;
        float eixoY = Input.GetAxisRaw("Vertical") * velocidade;

        rb.velocity = new Vector2(eixoX, eixoY);
        Debug.Log($"Horizontal: {eixoX}, Vertical: {eixoY}");
    }


    void AtualizarSliderMana()
    {

        sliderMana.value = ManaAtual / ManaInicial;
    }

}