using TMPro;
using UnityEngine;

public class ScoreSceneControll : MonoBehaviour 
{
    public TextMeshProUGUI avaliacaoTexto;

    private void Update()
    {
        int scorep = Lixeira.Pontuacao; // Acessa a pontua��o diretamente pela classe Lixeira

        if (scorep < 10)
        {
            avaliacaoTexto.text = "Voc� jogou mal.";
            
        }
        else if (scorep == 10)
        {
            avaliacaoTexto.text = "Voc� jogou de maneira decente.";
        }
        else
        {
            avaliacaoTexto.text = "Voc� jogou muito bem!";
        }
    }
}




