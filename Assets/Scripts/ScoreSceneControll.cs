using TMPro;
using UnityEngine;

public class ScoreSceneControll : MonoBehaviour 
{
    public TextMeshProUGUI avaliacaoTexto;

    private void Update()
    {
        int scorep = Lixeira.Pontuacao; // Acessa a pontuação diretamente pela classe Lixeira

        if (scorep < 10)
        {
            avaliacaoTexto.text = "Você jogou mal.";
            
        }
        else if (scorep == 10)
        {
            avaliacaoTexto.text = "Você jogou de maneira decente.";
        }
        else
        {
            avaliacaoTexto.text = "Você jogou muito bem!";
        }
    }
}




