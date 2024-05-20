# ROS-VR Integration SDK

## Overview

This repository contains an extended version of an open-source SDK for creating ROS (Robot Operating System) level files and  middleware for digital twin systems. The extension adds integration with Virtual Reality (VR) environments via the generation of ROS subscribers and publishers that interact with ROS using the ROS-TCP-Connector.

## Features

- **ROS Node Configuration**: Configure the twin environment using a YAML file.
- **ROS Topic Integration**: Publish and subscribe to ROS topics within the virtual environment.
- **Middleware Flagging**: Control middleware interaction through configurable flags.
- **Unity Integration**: Enable interaction with Unity3D environments through subscriber and publisher .

## Installation

1. Clone this repository to your local machine:

    ```bash
    git clone https://github.com/your-username/ros-vr-sdk.git
    ```

2. Install dependencies using `pip`:

    ```bash
    pip install -r requirements.txt
    ```

3. Run the setup script to configure the SDK:

    ```bash
    python setup.py install
    ```

## Usage

1. Modify the `config.yaml` file to specify the ROS node configuration, including topics to publish and subscribe, middleware flags, and Unity integration flags.

    ```yaml
    ros_node:
      name: test
      topics:
        publish:
          topic_1:
            name: "cmd_vel"
            type:  "geometry_msgs/Twist"
            middleware_flag: 1
            unity_sub_flag: 1
            unity_pub_flag: 1
        subscribe:
          topic_1:
            name: "control"
            type:  "std_msgs/String"
            middleware_flag: 1
            unity_sub_flag: 0
            unity_pub_flag: 0
          topic_2:
            name: "metric"
            type:  "std_msgs/String"
            middleware_flag: 1
            unity_sub_flag: 0
            unity_pub_flag: 0
          topic_3: 
            name: "cam"
            type:  "sensor_msgs/CompressedImage"
            middleware_flag: 1
            unity_sub_flag: 1
            unity_pub_flag: 0
          topic_4: 
            name: "ultra_sonic_unity"
            type:  "std_msgs/Float32"
            middleware_flag: 0
            unity_sub_flag: 1
            unity_pub_flag: 0
    ```

2. Run the SDK with the configured settings:

    ```bash
    python ros_vr_sdk.py
    ```

## Contributing

Contributions are welcome! Please fork this repository and submit a pull request with your changes. Ensure to follow the coding style and include appropriate documentation.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
