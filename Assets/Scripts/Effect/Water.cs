﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <inheritdoc />
/// <summary>
/// 水纹播放的特效，一些不能直接做成动画的图片，直接使用代码播放
/// </summary>
public class Water : MonoBehaviour
{
    private SpriteRenderer sr;

    public Sprite[] pictures;

    private int count = 0;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        sr.sprite = pictures[count];
        count++;
        if (count == pictures.Length)
        {
            count = 0;
        }
    }
}