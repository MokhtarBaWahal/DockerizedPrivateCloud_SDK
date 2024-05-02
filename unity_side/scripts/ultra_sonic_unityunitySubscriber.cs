
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;  
             

// Add any variables here, if you want to make it visable in the unity editor make it public
           
public class ultra_sonic_unitySubscriber : MonoBehaviour
{
    void Start()
    {
        // This line starts the ROS connection
        ROSConnection.GetOrCreateInstance().Subscribe<Float32Msg>("ultra_sonic_unity", ultra_sonic_unity_OnMsgReceived);
    }

    void ultra_sonic_unity_OnMsgReceived (Float32Msg msg )
    {
        // Add the logic of your app when receiving the new msg from the ros topic ultra_sonic_unity.
    }
}
