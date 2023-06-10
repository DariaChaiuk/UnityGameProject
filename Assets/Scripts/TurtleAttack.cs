using System;
using UnityEngine;
using UnityEngine.AI;

public class TurtleAttack : MonoBehaviour
{
    public int speed;
    public float attackDistance;
    public float followDistance;
    public GameObject player;
    private Animator mAnimator;
    public float damage;
    HealthBarHUD health;
    public float delay = 3;
    float time;
    float timeDelay;

    public delegate void OnDamage();
    public OnDamage onDamageCallback;


    void Start()
    {
        time = 0f;
        timeDelay = 2f;

        mAnimator = GetComponent<Animator>();
        health = FindObjectOfType<HealthBarHUD>();
    }

    // Update is called once per frame
    void Update()
    {
        mAnimator.ResetTrigger("RunTrg");
        mAnimator.ResetTrigger("AttackTrg");
        mAnimator.ResetTrigger("CalmTrg");
        if(Vector3.Distance(transform.position, player.transform.position) <= attackDistance && mAnimator != null) {
            AttackStart();
        }
        else if(Vector3.Distance(transform.position, player.transform.position) <= followDistance){
            mAnimator.SetTrigger("RunTrg");
            transform.LookAt(player.transform);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        } 
        else if(Vector3.Distance(transform.position, player.transform.position) > followDistance && mAnimator != null){
            mAnimator.SetTrigger("CalmTrg");
        }
    }

    private void AttackStart() {
        transform.LookAt(player.transform);

        time = time + 1f * Time.deltaTime;
        mAnimator.SetTrigger("AttackTrg");

        if (time >= timeDelay) {
            time = 0f;
            health.Hurt(damage);
        }
    }
}
