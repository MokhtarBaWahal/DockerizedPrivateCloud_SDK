
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Geometry;  
             

// Add any variables here, if you want to make it visable in the unity editor make it public
           
public class cmd_velSubscriber : MonoBehaviour
{
    void Start()
    {
        // This line starts the ROS connection
        ROSConnection.GetOrCreateInstance().Subscribe<TwistMsg>("cmd_vel", cmd_vel_OnMsgReceived);
    }

    void cmd_vel_OnMsgReceived (TwistMsg msg )
    {
        // Add the logic of your app when receiving the new msg from the ros topic cmd_vel.
    }
}
