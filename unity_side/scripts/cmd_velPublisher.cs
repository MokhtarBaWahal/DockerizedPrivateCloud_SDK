
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Geometry;  

public class cmd_velSubscriber : MonoBehaviour
{

    void Start()
    {
        // start the ROS connection
        ROSConnection.GetOrCreateInstance().RegisterPublisher<TwistMsg>("cmd_vel");
    }

    private void Update()
    {
        // Add the logic of your app when publishing the new msg from the ros topic "cmd_vel"
    }
}
