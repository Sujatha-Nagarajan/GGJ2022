using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using Platformer.Mechanics;

public class NonDualityEffect : MonoBehaviour
{
    // Start is called before the first frame update
    private Material material;
    //public float strength;

    private PlayerController player;

    void Awake()
    {
        material = new Material(Shader.Find("Hidden/NonDualityShader"));

        player = GameObject.Find("Player").GetComponent<PlayerController>();
        if (!player)
        {
            Debug.Log("player not found" + this.GetType().ToString());
        }

    }

    void OnRenderImage(RenderTexture source, RenderTexture dest)
    {
        // The health of player depics duality strength
        float dualityStrength = player.health.GetHealth();
        material.SetFloat("_strength", 1f - dualityStrength);
        Graphics.Blit(source, dest, material);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
