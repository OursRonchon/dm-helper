﻿using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class TurnGrid : MonoBehaviour {

	public Button 		GridButton;
	public Button[,] 	buttonsArray;

	int WIDTH 			= 3;
	int HEIGHT 			= 6;

	void Start () {

		buttonsArray = new Button[WIDTH,HEIGHT];
		foreach (int y in Enumerable.Range(0, HEIGHT)) {
			foreach (int x in Enumerable.Range(0, WIDTH)) {
				buttonsArray [x, y] = Instantiate(GridButton);
                buttonsArray [x, y].GetComponent<TwoDCoord>().coord = new Vector2(x, y);
				buttonsArray [x, y].transform.SetParent(transform, false);
			}
		}
	}
}
