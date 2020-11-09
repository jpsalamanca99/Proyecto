﻿using UnityEngine;

public class WallController : MonoBehaviour {

    public static bool hit;

    public void changeHeight(float value){
        transform.parent.position = new Vector3(transform.parent.position.x, value - 15.7f, transform.parent.position.z);
    }

    public void changeDistance(float value){
        transform.parent.position = new Vector3(value, transform.parent.position.y, transform.parent.position.z);
    }

    public void resetColision(){
        hit = false;
    }
}
