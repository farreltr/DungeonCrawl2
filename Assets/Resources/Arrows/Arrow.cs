using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour
{
	 
		private Color originalColour;
		private GameController gameController;
		private Direction direction = Direction.NONE;
		private int Xcoord = -1;
		private int Ycoord = -1;

		public enum Direction
		{
				UP = 1,
				DOWN = 3,
				LEFT = 2,
				RIGHT = 0,
				NONE = 4
		}

		void Start ()
		{
				originalColour = renderer.material.color;
				gameController = GameObject.FindObjectOfType<GameController> ();

		}

		void OnMouseDown ()
		{
				getGameController ().SetDestination (this);
		}  

		void OnMouseOver ()
		{
				renderer.material.color = Color.yellow;
		}

		void OnMouseExit ()
		{
				renderer.material.color = originalColour;
		}

		GameController getGameController ()
		{
				if (gameController == null) {
						gameController = GameObject.FindObjectOfType<GameController> ();
				}
				return gameController;
		}

		public void SetDirection (Direction direction)
		{
				this.direction = direction;
		}

		public Direction GetDirection ()
		{
				return this.direction;
		}

		public int GetXcoord ()
		{
				return Xcoord;
		}

		public void SetXcoord (int Xcoord)
		{
				this.Xcoord = Xcoord;
		}

		public int GetYcoord ()
		{
				return Ycoord;
		}

		public void SetYcoord (int Ycoord)
		{
				this.Ycoord = Ycoord;
		}

}