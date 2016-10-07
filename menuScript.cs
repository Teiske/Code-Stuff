using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class menuScript : MonoBehaviour {
    public Canvas quitMenu;
    public Canvas pauseMenu;
    public Button startText;
    public Button exitText;
    public Button continueGameText;
    public Button quitToMenuGameText;
    public Button exitGameText;
   
    void Start() {

        quitMenu = quitMenu.GetComponent<Canvas>();
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        continueGameText = continueGameText.GetComponent<Button>();
        quitToMenuGameText = quitToMenuGameText.GetComponent<Button>();
        exitGameText = exitGameText.GetComponent<Button>();
        quitMenu.enabled = false;
        pauseMenu.enabled = false;

    }
    public void QuitToMenuPress() {

        SceneManager.LoadScene(0);

    }
    public void ContinuePress() {

        pauseMenu.enabled = false;

    }
    public void EscapePress() {

        if (Input.GetKey("escape")) {
            pauseMenu.enabled = true;
        }

    }
    public void ExitPress() {

        quitMenu.enabled = true;
        startText.enabled = false; 
        exitText.enabled = false;

    }
    public void NoPress() {

        quitMenu.enabled = false; 
        startText.enabled = true; 
        exitText.enabled = true;

    }
    public void StartLevel() {

        SceneManager.LoadScene(1); 

    }
    public void ExitGame() {

        Application.Quit();
         
    }

}
