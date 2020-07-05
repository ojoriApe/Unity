using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance; //싱글턴을 할당할 전역변수

    public bool isGameover = false; //게임오버상태
    public Text scoreText; //점수출력 텍스ㅡ UI
    public GameObject gameoverUI; //게임오버 시 활성화할 UI게임 오브젝트

    private int score = 0;

    //게임 시작과 동시에 싱글턴 구성
    void Awake()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 존재합니다.");
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameover && Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int newScore)
    {
        if(!isGameover)
        {
            score += newScore;
            scoreText.text = "점수 : " + score;
        }
    }
}
