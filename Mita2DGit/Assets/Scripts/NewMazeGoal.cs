using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMazeGoal : MonoBehaviour
{
    public int PillPoint;
    public static bool IsWin = false;
    [SerializeField] ParticleSystem DigestParticle = null;
    [SerializeField] ParticleSystem DigestParticle2 = null;
    // Start is called before the first frame update
    void Start()
    {
        PillPoint = 0;
    }

    
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pill")
        {
            PillPoint += 1;
            Debug.Log(PillPoint);
            Debug.Log("youve entered the stomach");
            DigestParticle.Play();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Pill1")
        {
            PillPoint += 1;
            //Debug.Log(PillPoint);
            Debug.Log("youve entered the stomach");
            DigestParticle.Play();
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Pill3")
        {
            PillPoint += 1;
            //Debug.Log(PillPoint);
            Debug.Log("youve entered the stomach");
            DigestParticle.Play();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Pill4")
        {
            PillPoint += 1;
            //Debug.Log(PillPoint);
            Debug.Log("youve entered the stomach");
            DigestParticle.Play();
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "Pill5")
        {
            PillPoint += 1;
            //Debug.Log(PillPoint);
            Debug.Log("youve entered the stomach");
            DigestParticle.Play();
            Destroy(col.gameObject);
        }
    }

    /*
    private void OnCollisionEnter2D(Collision2D col)
    {
        PillPoint += 1;
        Debug.Log(PillPoint);
        Destroy(gameObject);
    }
    */




    // Update is called once per frame
    void Update()
    {
        if(PillPoint == 5)
        {
             Debug.Log("you did it!");
            // SceneManager.LoadScene("MitaWakePOV");
            IsWin = true;
        }
    }
}
