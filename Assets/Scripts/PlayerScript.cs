using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	float direcao_x;
	float posicaoInicial,posicaoFinal;
	public Transform[] posicoes;
	int posicaoAtual = 1;
	float velocidade = 5;
	void Update () {
		//Fire1 - Clique do mouse, touch ou ctrl esquerdo
		if (Input.GetButtonDown ("Fire1")) {	
			posicaoInicial = Input.mousePosition.x;
		}else if(Input.GetButtonUp("Fire1")){
				posicaoFinal = Input.mousePosition.x;
			

			//Define a diração
				direcao_x = posicaoFinal - posicaoInicial;
				if(direcao_x > 0 && posicaoAtual < 2){
					posicaoAtual++;
			}else if(direcao_x < 0 && posicaoAtual > 0){
				posicaoAtual--;
			}
		}
		transform.position = Vector3.Lerp (transform.position, posicoes [posicaoAtual].position, velocidade * Time.deltaTime);

		print (posicaoAtual);
	}
}
