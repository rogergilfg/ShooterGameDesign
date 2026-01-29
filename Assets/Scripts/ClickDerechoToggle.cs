using UnityEngine;

public class ClickDerechoToggle : MonoBehaviour
{
    bool activo = false;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // click derecho
        {
            activo = !activo;

            if (activo)
                Activar();
            else
                Desactivar();
        }
    }

    void Activar()
    {
        Debug.Log("Estado ON");
        anim.SetBool("Apuntar", true);
    }

    void Desactivar()
    {
        Debug.Log("Estado OFF");
        anim.SetBool("Apuntar", false);

    }
}

