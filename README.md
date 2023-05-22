# Accuracy and Fairness in Production Computer Vision Systems - Embedded Vision Summit 2023
This repository contains the code samples for the data that was presented during the Embedded Vision Summit Talk.

Link to video recording of talk:  (Coming Soon)

## Cocostats.ipynb Notebook
This is a Colab Notebook that contains the bulk of the material from the talk.  There are instructions included in the notebook.

## UnityHumans Project
This is a Unity project for generating the synthetic dataset that was referenced in the talk.  It has been tested in the [`2021.3.20f1`](https://unity.com/releases/editor/whats-new/2021.3.20#release-notes) version of the Unity editor.

After installing the editor, load the project.  The project is set by default to generate 200 images with bounding boxes in SOLO format.  To generate the dataset, simply press the Play button at the top of the editor.  Once you have run the simulation to completion, files will appear in the folder specified on the `Main Camera` object, under the property `Latest Generated Dataset`.

This project makes use of the [Unity Perception Package](https://github.com/Unity-Technologies/com.unity.perception) and the [Unity Synthetic Humans Package](https://github.com/Unity-Technologies/com.unity.cv.synthetichumans).  There is extensive documentation and tutorials for both packages, so please reference these if you would like to extend the sample for your own purposes.

## Contributing
At this time, this project is not acception contributions due to the work needed to maintain an open source version.  However, please reach out to me if you are interested in developing this example further, as I would consider doing this if there were enough interested parties.