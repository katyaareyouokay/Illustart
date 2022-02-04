using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject Character1;
    public GameObject Character2;
    public GameObject mainMenu;
    public GameObject charactersMenu;
    public GameObject Interaction;
    public GameObject Hide;
    // персонажи

    // Start is called before the first frame update
    void Start()
    {
        // скрыть все панели
        mainMenu.SetActive(false); // отображаем главное меню
        charactersMenu.SetActive(false);
        Interaction.SetActive(false);
        Hide.SetActive(false);
        Character1.SetActive(false);
        Character2.SetActive(false);
    }

    // Update is called once per frame
    public void ShowMainMenu()
    {
        mainMenu.SetActive(true);
        charactersMenu.SetActive(false);
        Interaction.SetActive(false);
        Hide.SetActive(false);
        // скрыть все остальные
    }

    public void ShowCharacters()
    {
        charactersMenu.SetActive(true);
        mainMenu.SetActive(false);
        Interaction.SetActive(false);
        Hide.SetActive(false);
    }

    public void ShowInteraction()
    {
        charactersMenu.SetActive(false);
        mainMenu.SetActive(false);
        Interaction.SetActive(true);
        Hide.SetActive(true);
    }

    public void ToggleInteraction()
    {
        Interaction.SetActive(!Interaction.activeSelf);
    }

    public void ShowCharacter1()
    {
        Character1.SetActive(true);
        Character2.SetActive(false);
    }

    public void ShowCharacter2()
    {
        Character2.SetActive(true);
        Character1.SetActive(false);
    }
}
