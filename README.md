<p align="center">
  HOLOREGISTRATION 2020
</p>

HoloRegisration 2020 is a Windows Unity based appliction that allows augmented reality overlays of human organs over the body. It supports models of the gltf(and glb) format and is intended to work with the HoloPipelines segmentation output. As of right now, supported models are lungs, kidneys and abdominal organs. Currently the application supports overlay of Lungs, Kidneys and Abdominal organs which can be obtained from the HoloViewer2020

# Getting started with the latest release
Download the latest release and launch the HoloRegistration.exe executable.
To run this application without major performance penalites, a system with a GPU is advised.

## Usage
Place any glb models to be used inside the model folder and during run time select the model from the dropdown menu.

Alternatively, models can be loaded directly from launch using the following command line format
```bash
HoloRegistration2020.exe -model "model path" -organ "organname"

e.g.

HoloRegistration2020.exe -model "C:\User\Documents\lungs.glb" -organ "lungs"
```

![5abce4c31e6f9582a0469a47960e1fee](https://user-images.githubusercontent.com/24493864/81484280-4023c300-923c-11ea-949d-589f64c09c9d.png)
<img width="340" alt="lung scan" src="https://user-images.githubusercontent.com/24493864/81484280-4023c300-923c-11ea-949d-589f64c09c9d.png">


# Source Code
This repository includes the source code for this application along with the [OpenPosePlugin](https://github.com/CMU-Perceptual-Computing-Lab/openpose_unity_plugin) used for pose tracking.

To start development, the getModels.bat and getPlugins.bat need to be run first to download the body data and pose estimation models. Then the project can be loaded into Unity. This was developed using Unity version 2018.4.0f1. Newer versions are likely to work but not garunteed.

# Acknowledgements
Main authors: Immanuel Baskaran, Abhinath Kumar, Carlo Winkelhake, Daren Alfred

Supervisors: Prof. Dean Mohamedally, Prof. Neil Sebire, Sheena Visram

Built at [University College London](https://www.ucl.ac.uk/) in cooperation with [Intel™](https://www.intel.co.uk) and [GOSH DRIVE](https://www.goshdrive.com/).

