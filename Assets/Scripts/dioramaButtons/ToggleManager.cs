using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToggleManager : MonoBehaviour
{
//--------------------singleton-------------------------------\\
    public static ToggleManager Instance {get; private set;}
    private void Awake()
	{
		if (Instance != null && Instance != this) {
			Destroy(this);
		} 
		else { 
			Instance = this;
		}
        items = new List<Toggle_Item>();
	}
//------------------------------------------------------------\\

    public GameObject buttonPanel;
    public GameObject buttonPrefab;
    private List<Toggle_Item> items;

    public void RegisterItem(Toggle_Item toAdd)
    {
        items.Add(toAdd);
        CreateButtons(toAdd);
    }

    void CreateButtons(Toggle_Item item)
    {
        // GameObject newButton = DefaultControls.CreateButton(new DefaultControls.Resources());
        GameObject newButton = Instantiate(buttonPrefab);
        
        newButton.GetComponent<Button>().onClick.AddListener(item.Toggle);
        newButton.GetComponentInChildren<Text>().text = item.buttonText;
        newButton.transform.SetParent(buttonPanel.transform, false);
    }
}
