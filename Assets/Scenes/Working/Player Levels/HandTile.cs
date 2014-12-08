using UnityEngine;
using System.Collections;

public class HandTile : MonoBehaviour
{

		private Color originalColour;
		private Vector3 slotPosition = Vector3.zero;
	
		void Start ()
		{
				originalColour = gameObject.renderer.material.color;
				slotPosition = transform.position;
				this.transform.parent = GameObject.FindObjectOfType<PlayerHand> ().transform;
		}

		void OnMouseDown ()
		{
				PlayerHand parent = gameObject.GetComponentInParent<PlayerHand> ();
				parent.SetSelected (this);
		}  

		public void SetSelectedColour ()
		{
				gameObject.renderer.material.color = Color.yellow;
		}

		public void SetNotSelectedColour ()
		{
				gameObject.renderer.material.color = originalColour;
		}

		public Vector3 GetSlotPosition ()
		{
				return slotPosition;
		}
	
		public void SetSlotPosition (Vector3 slotPosition)
		{
				this.slotPosition = slotPosition;
		}

}
