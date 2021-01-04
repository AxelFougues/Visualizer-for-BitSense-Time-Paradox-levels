using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class ImageReconBehaviour : MonoBehaviour{

    public GameObject spawnObject;
    private ARTrackedImageManager tracker;

    private void Awake() {
        tracker = FindObjectOfType<ARTrackedImageManager>();
    }

    public void OnEnable() {
        tracker.trackedImagesChanged += onImageChanged;
    }

    private void OnDisable() {
        tracker.trackedImagesChanged -= onImageChanged;
    }

    private void onImageChanged(ARTrackedImagesChangedEventArgs args) {
        foreach (var image in args.added) {
            //GameObject obj = Instantiate(spawnObject);

        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
