using UnityEngine;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {

	// Riferimenti controllers
	public GameController GameControllerInstance;
	// Settings del livello
	public int Level;
	public List<Transform> SpawnPointsForEnemies;
	// Variabili di comportamento
	public bool isMandatorySaveNPC;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void SetupScene(){
		GameControllerInstance.Level = Level;
		if(isMandatorySaveNPC){

		}else{

		}
	}
}
