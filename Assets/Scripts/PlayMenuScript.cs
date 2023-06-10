using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 
public class PlayMenuScript : MonoBehaviour
{
// Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/Level_1");
    }
    public void AboutGame()
    {
        SceneManager.LoadScene("Scenes/About");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Scenes/Settings");
    }
    public void Levels(){
        SceneManager.LoadScene("Scenes/Levels");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Scenes/Level_1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Scenes/Level_2");
    }
    public void ControlButtons()
    {
        SceneManager.LoadScene("Scenes/ControlButtons");
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("We are quit");
        Application.Quit();
    }
}
