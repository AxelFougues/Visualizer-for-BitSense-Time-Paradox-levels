using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour {

    public Slider cutoffSlider;
    public Slider explodeSlider;
    public Button renderButton;

    bool renderType = false;

    private void Start() {
        if(renderType) cutoffSlider.gameObject.SetActive(false);
        else cutoffSlider.gameObject.SetActive(true);
    }

    public void onToggleRenderType() {
        LevelVisualizer visualizer = FindObjectOfType<LevelVisualizer>();
        if (visualizer != null) { 
            if (renderType) {
                visualizer.setDefault();
                renderButton.GetComponentInChildren<Text>().text = "T";
            } else {
                visualizer.setCutout();
                renderButton.GetComponentInChildren<Text>().text = "C";
            }
            renderType = !renderType;
        }
    }

    public void onCutoffSlider() {
        LevelVisualizer visualizer = FindObjectOfType<LevelVisualizer>();
        if (visualizer != null) visualizer.setCutoff(cutoffSlider.value);
    }

    public void onExplodeSlider() {
        LevelVisualizer visualizer = FindObjectOfType<LevelVisualizer>();
        if (visualizer != null) visualizer.setExplodeOffset(explodeSlider.value);
    }

    public void setMap(Level level) {
        LevelVisualizer visualizer = FindObjectOfType<LevelVisualizer>();
        if (visualizer != null) {
            visualizer.setMap(level);
            if (!renderType) {
                visualizer.setDefault();
            } else {
                visualizer.setCutout();
            }
        }
    }
}
