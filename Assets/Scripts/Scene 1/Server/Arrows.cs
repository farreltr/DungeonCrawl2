using UnityEngine;
using System.Collections;

public class Arrows : MonoBehaviour
{
		private GameObject sword;
		public static Arrows arrows;
	
		void Awake ()
		{
				if (arrows == null) {
						DontDestroyOnLoad (arrows);
						arrows = this;
				} else if (arrows != this) {
						Destroy (gameObject);
				}
		}

		void Start ()
		{
				DontDestroyOnLoad (gameObject);
				sword = Resources.Load<GameObject> ("Arrows/arrow");
				SpriteRenderer renderer = sword.GetComponent<SpriteRenderer> ();
				renderer.sortingLayerName = "Arrow";
				renderer.sortingOrder = 5;
				RightArrows ();
				LeftArrows ();
				UpArrows ();
				DownArrows ();
		}
	
		void RightArrows ()
		{
				for (int y = 1; y < TileMap.size_y - 1; y++) {
						Vector3 position = new Vector3 (TileMap.tileSize * 0.5f, y * TileMap.tileSize + (TileMap.tileSize * 0.5f), 0);
						Quaternion rotation = Quaternion.Euler (0, 0, 270);
						GameObject go = (GameObject)Instantiate (sword, position, rotation);
						Arrow arrow = go.GetComponent<Arrow> ();
						arrow.transform.tag = "Right Arrow";
						arrow.gameObject.layer = this.gameObject.layer;
						arrow.name = arrow.transform.tag;
						arrow.transform.parent = this.gameObject.transform;
						arrow.SetDirection (Arrow.Direction.RIGHT);
						arrow.SetXcoord (0);
						arrow.SetYcoord (y);

				}
		}

		void LeftArrows ()
		{
				//Arrows pointing right
				for (int y = 1; y < TileMap.size_y - 1; y++) {
						Vector3 position = new Vector3 ((TileMap.size_x - 1) * TileMap.tileSize + (TileMap.tileSize * 0.5f), y * TileMap.tileSize + (TileMap.tileSize * 0.5f), 0);
						Quaternion rotation = Quaternion.Euler (0, 0, 90);
						GameObject go = (GameObject)Instantiate (sword, position, rotation);
						Arrow arrow = go.GetComponent<Arrow> ();
						arrow.transform.tag = "Left Arrow";
						arrow.gameObject.layer = this.gameObject.layer;
						arrow.name = arrow.transform.tag;
						arrow.transform.parent = this.gameObject.transform;
						arrow.SetDirection (Arrow.Direction.LEFT);
						arrow.SetXcoord (TileMap.size_x - 1);
						arrow.SetYcoord (y);
				}
		}

		void UpArrows ()
		{
				//Arrows pointing right
				for (int x = 1; x <  TileMap.size_x - 1; x++) {
						Vector3 position = new Vector3 (x * TileMap.tileSize + TileMap.tileSize * 0.5f, 0 * TileMap.tileSize + (TileMap.tileSize * 0.5f), 0);
						Quaternion rotation = Quaternion.Euler (0, 0, 0);
						GameObject go = (GameObject)Instantiate (sword, position, rotation);
						Arrow arrow = go.GetComponent<Arrow> ();
						arrow.transform.tag = "Up Arrow";
						arrow.gameObject.layer = this.gameObject.layer;
						arrow.name = arrow.transform.tag;
						arrow.transform.parent = this.gameObject.transform;
						arrow.SetDirection (Arrow.Direction.UP);
						arrow.SetXcoord (x);
						arrow.SetYcoord (0);
				}
		}

		void DownArrows ()
		{
				//Arrows pointing right
				for (int x = 1; x <  TileMap.size_x - 1; x++) {
						Vector3 position = new Vector3 (x * TileMap.tileSize + TileMap.tileSize * 0.5f, (TileMap.size_y - 1) * TileMap.tileSize + (TileMap.tileSize * 0.5f), 0);
						Quaternion rotation = Quaternion.Euler (0, 0, 180);
						GameObject go = (GameObject)Instantiate (sword, position, rotation);
						Arrow arrow = go.GetComponent<Arrow> ();
						arrow.transform.tag = "Right Arrow";
						arrow.gameObject.layer = this.gameObject.layer;
						arrow.name = arrow.transform.tag;
						arrow.transform.parent = this.gameObject.transform;
						arrow.SetDirection (Arrow.Direction.DOWN);
						arrow.SetXcoord (x);
						arrow.SetYcoord (TileMap.size_y - 1);

				}
		}

}