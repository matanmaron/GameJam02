﻿using Anima2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMeshSwapper : MonoBehaviour
{
    [SerializeField] SpriteMeshInstance smihead;
    [SerializeField] SpriteMeshInstance smichest;
    [SerializeField] SpriteMeshInstance smitorso;
    [SerializeField] SpriteMeshInstance smifarm;
    [SerializeField] SpriteMeshInstance smifhand;
    [SerializeField] SpriteMeshInstance smibarm;
    [SerializeField] SpriteMeshInstance smiband;
    [SerializeField] SpriteMeshInstance smifleg;
    [SerializeField] SpriteMeshInstance smifboot;
    [SerializeField] SpriteMeshInstance smibleg;
    [SerializeField] SpriteMeshInstance smibboot;

    [SerializeField] SpriteMesh phead;
    [SerializeField] SpriteMesh pchest;
    [SerializeField] SpriteMesh ptorso;
    [SerializeField] SpriteMesh pfarm;
    [SerializeField] SpriteMesh pfhand;
    [SerializeField] SpriteMesh pbarm;
    [SerializeField] SpriteMesh pband;
    [SerializeField] SpriteMesh pfleg;
    [SerializeField] SpriteMesh pfboot;
    [SerializeField] SpriteMesh pbleg;
    [SerializeField] SpriteMesh pbboot;

    [SerializeField] SpriteMesh rhead;
    [SerializeField] SpriteMesh rchest;
    [SerializeField] SpriteMesh rtorso;
    [SerializeField] SpriteMesh rfarm;
    [SerializeField] SpriteMesh rfhand;
    [SerializeField] SpriteMesh rbarm;
    [SerializeField] SpriteMesh rband;
    [SerializeField] SpriteMesh rfleg;
    [SerializeField] SpriteMesh rfboot;
    [SerializeField] SpriteMesh rbleg;
    [SerializeField] SpriteMesh rbboot;

    private CharacterBehaviour character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!character.isRobotLegs)
        {
            smifleg.spriteMesh =  pfleg;
            smifboot.spriteMesh = pfboot;
            smibleg.spriteMesh =  pbleg;
            smibboot.spriteMesh = pbboot;
        }
        else
        {
            smifleg.spriteMesh =  rfleg;
            smifboot.spriteMesh = rfboot;
            smibleg.spriteMesh =  rbleg;
            smibboot.spriteMesh = rbboot;
        }

        if (!character.isRobotArms)
        {
            smifarm.spriteMesh =  pfarm;
            smifhand.spriteMesh = pfhand;
            smibarm.spriteMesh =  pbarm;
            smiband.spriteMesh = pband;
        }
        else
        {
            smifarm.spriteMesh =  rfarm;
            smifhand.spriteMesh = rfhand;
            smibarm.spriteMesh =  rbarm;
            smiband.spriteMesh = rband;
        }

        if (!character.isRobotBrain)
        {
            smihead.spriteMesh = phead;
            smichest.spriteMesh = pchest;
            smitorso.spriteMesh = ptorso;
        }
        else
        {
            smihead.spriteMesh = rhead;
            smichest.spriteMesh = rchest;
            smitorso.spriteMesh = rtorso;
        }
    }
}
