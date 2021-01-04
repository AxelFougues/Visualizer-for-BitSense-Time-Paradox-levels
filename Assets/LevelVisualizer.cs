using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelVisualizer : MonoBehaviour{
    public Level level;
    public MeshRenderer obstacles;
    public MeshRenderer objective;

    protected MeshRenderer[] renderers;

    private void Start() {
        setDefault();
    }

    public void setMap(Level level) {
        this.level = level;
    }

    public void setCutout() {
        obstacles.material = level.obsCutout;
        objective.material = level.objCutout;
    }

    public void setDefault() {
        obstacles.material = level.obsDefault;
        objective.material = level.objDefault;
    }

    public void setCutoff(float cutoff) {
        obstacles.material.SetFloat("_Cutoff", cutoff);
        objective.material.SetFloat("_Cutoff", cutoff);
    }

    public void setExplodeOffset(float offset) {
        obstacles.transform.localScale = Vector3.one * (1.0f + offset);
        objective.transform.localScale = Vector3.one * (1.0f - offset);
    }

}
