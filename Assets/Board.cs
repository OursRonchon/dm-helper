﻿using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour {

	public Toggle 		BoardSquare;
	public Toggle[,] 	squaresArray;

    int WIDTH 			= 17;
    int HEIGHT 			= 17;

    void Start() {

		squaresArray = new Toggle[WIDTH,HEIGHT];
		foreach (int y in Enumerable.Range(0, HEIGHT)) {
			foreach (int x in Enumerable.Range(0, WIDTH)) {
				squaresArray [x, y] = Instantiate(BoardSquare);
				squaresArray [x, y].GetComponent<TwoDCoord> ().coord = new Vector2(x, y);
                squaresArray [x, y].transform.SetParent(transform, false);
			}
		}
	}
}
