using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IntroNPC : Collidable
{

    public string messageTop;
    public string messageDown;

    public float cooldown = 2.0f;
    private float lastShout;

    protected override void Start()
    {
        base.Start();
        lastShout = -cooldown;
    }
    protected override void OnCollide(Collider2D coll)
    {
        if (Time.time - lastShout > cooldown)
        {
            lastShout = Time.time;
            GameManager.instance.ShowText(messageTop, 25, Color.white, transform.position + new Vector3(0,0.16f,0), Vector3.zero, cooldown);
            GameManager.instance.ShowText(messageDown, 25, Color.white, transform.position + new Vector3(0, -0.16f, 0), Vector3.zero, cooldown);
        }
    }
}
