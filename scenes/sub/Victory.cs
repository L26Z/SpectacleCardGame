using Godot;
using System;
using TeicsoftSpectacleCards.scripts.audio;
using TeicsoftSpectacleCards.scripts.autoloads;

public partial class Victory : Control
{
    private AudioEngine audioEngine;
    private SceneLoader sceneLoader;
    
    Label label;
    
    
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        audioEngine = GetNode<AudioEngine>("/root/audio_engine");
        sceneLoader = GetNode<SceneLoader>("/root/scene_loader");
        
        label = GetNode<Label>("ColorRect/ColorRect/VBoxContainer/Spectacle Points");
        label.Text = sceneLoader.SpectaclePoints + " Spectacle Points!";
    }
    
    private void OnTimerTimeout()
    {
        
        
        sceneLoader.GoToScene("res://scenes/main/Credits.tscn");
        audioEngine.PlayMusic("Shop_loop_audio.wav");
    }
    
}
