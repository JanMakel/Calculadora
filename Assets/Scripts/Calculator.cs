using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Calculator : MonoBehaviour
{
    public InputField inputField;
    private string operacionActual;
    private double primerNumero;


    private void Start()
    {
        Limpiar();
    }

    // Función para manejar los botones numéricos
    public void BotonNumeroPresionado(string numero)
    {
        inputField.text += numero;
    }

    // Función para manejar los botones de operación
    public void BotonOperacionPresionado(string operacion)
    {
        if (inputField.text != "")
        {
            primerNumero = double.Parse(inputField.text);
            operacionActual = operacion;
            Limpiar();
        }
    }

    // Función para calcular y mostrar el resultado
    public void BotonIgualPresionado()
    {
        if (inputField.text != "")
        {
            double segundoNumero = double.Parse(inputField.text);
            switch (operacionActual)
            {
                case "+":
                    inputField.text = (primerNumero + segundoNumero).ToString();
                    break;
                case "-":
                    inputField.text = (primerNumero - segundoNumero).ToString();
                    break;
                case "*":
                    inputField.text = (primerNumero * segundoNumero).ToString();
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        inputField.text = (primerNumero / segundoNumero).ToString();
                    }
                    else
                    {
                        inputField.text = "Error";
                    }
                    break;
            }
        }
    }

    // Función para borrar el contenido del InputField
    public void Limpiar()
    {
        inputField.text = "";
    }

    
  
}

