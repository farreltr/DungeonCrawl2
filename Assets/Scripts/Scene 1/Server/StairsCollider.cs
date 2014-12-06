using UnityEngine;
using System.Collections;

public class StairsCollider : MonoBehaviour
{

		private GameController controller;
	
		void Start ()
		{
				controller = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		}

		void OnTriggerEnter2D (Collider2D collider)
		{
				GameObject colliderObject = collider.gameObject;
				string myName = GetFormattedName (gameObject);
				PlayerController playerController = colliderObject.transform.GetComponent<PlayerController> ();
				if (playerController != null) {
						if (myName == playerController.GetName ()) {
								playerController.isWinner = true;
								controller.GameOver ();
						} else if (myName == playerController.GetRespawnName () && playerController.isRespawn) {
								//do nothing
						} else {
								playerController.ChangeDirection ();
						}
				}
					
		}

		private static string GetFormattedName (GameObject o)
		{
				return o.name.Replace ("(Clone)", "");
		}

}
