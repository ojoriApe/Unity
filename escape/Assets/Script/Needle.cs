using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{

    private Rigidbody2D needleRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)  //2D를 붙일것
    {
        if(other.tag == "Player")
        {
            //상대방의 게임 오브젝트에서 PlayerController 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();
            Debug.Log("Die");
            if(playerController != null)
            {
                //상대방 PlayerController 컴포턴트의 Die() 메서드 실행
                playerController.Die();
                
            }
        }
    }
}
