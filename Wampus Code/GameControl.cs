using System;
public class GameControl
{
    //very very very rough outline, still need to add a ton of stuff
    //only a partial stub so far
    public GameControl()
    {
    }
    public void PauseGame()
    {
        //pauses the game upon pressing a key
    }
    public void ResumeGame()
    {
        //unpauses the game once that key is pressed again
    }
    //The Game Control Object keeps track of the game state(Currently playing
    //a game, displaying the splash screen, displaying the high scores).
    public bool isGamePaused()
    {
        return false;
    }
    public bool isGameBeingPlayed()
    {
        return false;
    }
    public bool isHighscoreOpen()
    {
        return false;
    }
    //The Game Control Object accepts and validates user input(that is, player
    //commands and game control commands). The trivia and high score
    //objects will manage their own user input.
    private void MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            //left mouse button pressed
        }
    }
    private void MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            //left mouse button released
        }
    }
    //The Game Control Object interacts with the GameLocations Object, the
    //Player Object, the Graphical Interface Object, the Trivia Management
    //System, and the High Score Management System
}

