package com.example.gfamobile.ui;

import android.content.pm.ActivityInfo;
import android.os.Bundle;

import dagger.android.support.DaggerAppCompatActivity;

public class PortraitDaggerAppCompatActivity extends DaggerAppCompatActivity {
    protected void onCreate(Bundle savedInstanceState)
    {
        super.onCreate(savedInstanceState);
        setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);
    }
}
