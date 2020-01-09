using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TheEnd : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI restartButton;
    private PlayerController playerController;
    public GameObject gameOverMenu;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(GameObject.Find("Ghost"));
        gameOverText.text = "You Win!";
        gameOverMenu.gameObject.SetActive(true);
        restartButton.text = "Restart?";
        GameObject.Find("Player").SendMessage("Finnish");
    }
}
