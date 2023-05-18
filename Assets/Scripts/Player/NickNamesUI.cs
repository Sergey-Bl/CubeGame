using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NickNamesUI : MonoBehaviour
{
    public GameObject playerPrefab;
    public TextMeshProUGUI nicknamesText;
    private List<string> nicknames = new List<string>();
    private Dictionary<GameObject, GameObject> nicknameInstances = new Dictionary<GameObject, GameObject>();
    private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public void AddPlayer(GameObject player)
    {
        if (nicknameInstances.ContainsKey(player))
        {
            Debug.Log("Player already exists in the dictionary.");
            return;
        }

        string nickname = GenerateRandomName();

        GameObject playerInstance = Instantiate(playerPrefab, player.transform.position, player.transform.rotation, player.transform);

        TextMeshProUGUI textComponent = playerInstance.GetComponentInChildren<TextMeshProUGUI>();

        if (textComponent != null)
        {
            textComponent.text = nickname;

            nicknames.Add(nickname);

            nicknameInstances.Add(player, playerInstance);
        }
        else
        {
            Debug.LogError("TextMeshProUGUI component not found on playerPrefab!");
        }

        UpdateNicknamesText();
    }

    public void RemovePlayer(GameObject player)
    {
        if (nicknameInstances.ContainsKey(player))
        {
            GameObject playerInstance = nicknameInstances[player];
            playerInstance.SetActive(false);

            nicknameInstances.Remove(player);
        }

        UpdateNicknamesText();
    }

    private void UpdateNicknamesText()
    {
        string nicknamesString = "Nicknames:\n";
        foreach (string nickname in nicknames)
        {
            nicknamesString += nickname + "\n";
        }
        nicknamesText.text = nicknamesString;
    }

    private string GenerateRandomName()
    {
        string name = "";

        for (int i = 0; i < 5; i++)
        {
            int randomIndex = Random.Range(0, alphabet.Length);
            char randomChar = alphabet[randomIndex];
            name += randomChar;
        }

        return name;
    }
}