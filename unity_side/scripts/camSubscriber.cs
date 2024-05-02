
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;  
             

// Add any variables here, if you want to make it visable in the unity editor make it public
           
public class camSubscriber : MonoBehaviour
{
    void Start()
    {
        // This line starts the ROS connection
        ROSConnection.GetOrCreateInstance().Subscribe<CompressedImageMsg>("cam", cam_OnMsgReceived);
    }

    void cam_OnMsgReceived (CompressedImageMsg msg )
    {
        // Add the logic of your app when receiving the new msg from the ros topic cam.
    }
}
