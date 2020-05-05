<p align="center">
  HOLOREGISTRATION 2020
</p>

HoloRegisration 2020 is a Windows Unity based appliction that allows augmented reality overlays of human organs over the body. It supports models of the gltf(and glb) format and is intended to work with the HoloPipelines segmentation output. As of right now, supported models are lungs, kidneys and abdominal organs. 

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

# Source Code
This repository includes the source code for this application along with the [OpenPosePlugin](https://github.com/CMU-Perceptual-Computing-Lab/openpose_unity_plugin) used for pose tracking.

To start development, the getModels.bat and getPlugins.bat need to be run first to download the body data and pose estimation models. Then the project can be loaded into Unity. This was developed using Unity version 2018.4.0f1. Newer versions are likely to work but not garunteed.

# Acknowledgements
Main authors: Immanuel Baskaran, Abhinath Kumar, Carlo Winkelhake, Daren Alfred

Supervisors: Prof. Dean Mohamedally, Prof. Neil Sebire, Sheena Visram

Built at [University College London](https://www.ucl.ac.uk/) in cooperation with [Intel™](https://www.intel.co.uk) and [GOSH DRIVE](https://www.goshdrive.com/).


Logo is derived from a work by <a href="https://www.freepik.com/">Freepik</a> at <a href="https://www.flaticon.com/">www.flaticon.com</a>.
