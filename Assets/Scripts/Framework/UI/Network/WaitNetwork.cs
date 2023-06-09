﻿using UnityEngine;

public class WaitNetwork : MonoBehaviour
{
    // 尤其在点击登录按钮，这种具有链接网络功能的按钮的时候，需要有一个转菊花的ui。
    // 但是因为网速有慢有快，不能一点击按钮就立即弹出转菊花，只能是在2s之内收不到回报的话才转菊花。
    // 更简单的方法是：一点按钮就打开转菊花UI，只不过不立即显示菊花，而是2s之后才显示菊花。收到汇报立即关闭整个转菊花UI即可。
    // 同时需要一个保底，就是说，加入超过10s依然没有汇报则关闭，并给个提示。
    // 同时注意监听回报消息的时候，需要注意，如果回报先于注册发生，可能导致这个UI关闭存在问题。
    
    // 有的时候需要等待http消息，有的时候等待游戏的逻辑消息
}
