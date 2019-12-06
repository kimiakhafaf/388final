using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour
{
    public static string GameOver = "gameover";
    public static string Game = "game";
    public static string MainMenu = "mainmenu";
    public void start_game()
    {
        SceneManager.LoadScene(Game);
    }

    public void main_menu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void game_over()
    {
        SceneManager.LoadScene(GameOver);
    }

}
