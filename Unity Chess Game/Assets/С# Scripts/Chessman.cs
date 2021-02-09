using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    public GameObject controller;
    public GameObject movePlate;
    
    private int xBoard = -1;
    private int yBoard = -1;
    
    private string player;
    
    public Sprite black_queen, black_horse, black_elephant, black_king, black_rook, black_pawn;
    public Sprite white_queen, white_horse, white_elephant, white_king, white_rook, white_pawn;

    
    // black_queen.transform.scale = new Vector3(0.25, 0.25, 1);

    
    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        SetCoords();

        switch (this.name)
        {
            case "black_queen": this.GetComponent<SpriteRenderer>().sprite = black_queen; break;
            case "black_horse": this.GetComponent<SpriteRenderer>().sprite = black_horse; break;
            case "black_elephant": this.GetComponent<SpriteRenderer>().sprite = black_elephant; break;
            case "black_king": this.GetComponent<SpriteRenderer>().sprite = black_king; break;
            case "black_rook": this.GetComponent<SpriteRenderer>().sprite = black_rook; break;
            case "black_pawn": this.GetComponent<SpriteRenderer>().sprite = black_pawn; break;
            
            case "white_queen": this.GetComponent<SpriteRenderer>().sprite = white_queen; break;
            case "white_horse": this.GetComponent<SpriteRenderer>().sprite = white_horse; break;
            case "white_elephant": this.GetComponent<SpriteRenderer>().sprite = white_elephant; break;
            case "white_king": this.GetComponent<SpriteRenderer>().sprite = white_king; break;
            case "white_rook": this.GetComponent<SpriteRenderer>().sprite = white_rook; break;
            case "white_pawn": this.GetComponent<SpriteRenderer>().sprite = white_pawn; break;
        }
    }

    public void SetCoords() 
    {
        float x = xBoard;
        float y = yBoard;

        x *= 0.66f;
        y *= 0.66f;

        x += -2.3f;
        y += -2.3f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }
}
