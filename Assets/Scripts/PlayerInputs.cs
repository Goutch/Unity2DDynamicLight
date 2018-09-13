﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    [SerializeField] private KeyCode moveLeftKey;

    [SerializeField] private KeyCode moveRightKey;

    [SerializeField] private KeyCode jumpKey;

    private PlayerController[] avatars;
    private int avatarIndex;

    private void Start()
    {
        avatars = GetComponentsInChildren<PlayerController>();
        avatars[0].gameObject.SetActive(false);
        avatarIndex = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            
            avatars[avatarIndex].Jump();
        }

        if (Input.GetKey(moveRightKey))
        {
            avatars[avatarIndex].Move(1);
        }

        if (Input.GetKey(moveLeftKey))
        {
            avatars[avatarIndex].Move(-1);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchAvatar();
        }
        
    }

    private void SwitchAvatar()
    {
        avatars[avatarIndex].gameObject.SetActive(false);
        if (avatarIndex == 0)
            avatarIndex = 1;
        else
        {
            avatarIndex = 0;
        }
        avatars[avatarIndex].gameObject.SetActive(true);
    }
}