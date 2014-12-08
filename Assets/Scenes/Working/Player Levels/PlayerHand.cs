using UnityEngine;
using System.Collections;

public class PlayerHand : MonoBehaviour
{

		public static HandTile selectedTile;

		void Strat ()
		{
				selectedTile = null;
		}

		public void SetSelected (HandTile select)
		{
				{
						if (selectedTile != null) {
								selectedTile.SetNotSelectedColour ();
						}
						selectedTile = select;
						selectedTile.SetSelectedColour ();
						print (selectedTile.name);
						print (selectedTile.renderer.material.color.ToString ());

				}
		}

		public HandTile getSelected ()
		{
				return selectedTile;
		}

		public bool isSelected ()
		{
				return selectedTile != null;
		}
}
