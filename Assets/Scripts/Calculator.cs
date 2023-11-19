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

    // Funci�n para manejar los botones num�ricos
    public void BotonNumeroPresionado(string numero)
    {
        inputField.text += numero;
    }

    // Funci�n para manejar los botones de operaci�n
    public void BotonOperacionPresionado(string operacion)
    {
        if (inputField.text != "")
        {
            primerNumero = double.Parse(inputField.text);
            operacionActual = operacion;
            Limpiar();
        }
    }

    // Funci�n para calcular y mostrar el resultado
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

    // Funci�n para borrar el contenido del InputField
    public void Limpiar()
    {
        inputField.text = "";
    }

    
  
}

