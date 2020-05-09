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

## UI
<img width="100" alt="lung scan" src="https://user-images.githubusercontent.com/24493864/81484476-96453600-923d-11ea-9ae2-12f735336f86.png">

Toggle Video Stream - Toggle the camera feed to be displayed on screen.

Ogran - Select the configuration for the model.

Model - Load model from the models folder. Any models that you wish to view in the application should be placed here.

Note: Organ and Model parameters do not have to be changed if the HoloRegistration2020 application is loaded through the HoloViewer2020.

Toggle model - Toggle the display of the model on the body.

Offset - Add an X or Y offset to the model onscreen. Values can be entered in the center text box or incrememnted using buttons. 

Rotation - Add an X, Y or Z rotation to the model onscreen. Values can be entered in the center text box or incrememnted using buttons.

Optional Setting - Neural Net Resolution: This allows users to increase the accuracy of the nueral net wif the hardware allows it. The values must be multiples of 16. If the first input is set to -1, the resultion will be made so that the aspect ratio matches the camera aspect ratio.

# Source Code
This repository includes the source code for this application along with the [OpenPosePlugin](https://github.com/CMU-Perceptual-Computing-Lab/openpose_unity_plugin) used for pose tracking.

To start development, the getModels.bat and getPlugins.bat need to be run first to download the body data and pose estimation models. Then the project can be loaded into Unity. This was developed using Unity version 2018.4.0f1. Newer versions are likely to work but not garunteed.

# Acknowledgements
Main authors: Immanuel Baskaran, Abhinath Kumar, Carlo Winkelhake, Daren Alfred

Supervisors: Prof. Dean Mohamedally, Prof. Neil Sebire, Sheena Visram

Built at [University College London](https://www.ucl.ac.uk/) in cooperation with [Intel™](https://www.intel.co.uk) and [GOSH DRIVE](https://www.goshdrive.com/).

