
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;  

public class camSubscriber : MonoBehaviour
{
    void Start()
    {
        // start the ROS connection
        ROSConnection.GetOrCreateInstance().Subscribe<CompressedImageMsg>("cam", cam_OnMsgReceived);
    }

    void cam_OnMsgReceived (CompressedImageMsg msg )
    {
        // Add the logic of your app when receiving the new msg from the ros topic cam.
    }
}
