
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Geometry;  


// Add any variables here, if you want to make it visable in the unity editor make it public
                        
public class cmd_velPublisher : MonoBehaviour
{

    void Start()
    {
        // This line starts the ROS connection
        ROSConnection.GetOrCreateInstance().RegisterPublisher<TwistMsg>("cmd_vel");
    }

    private void Update()
    {
        // Add the logic of your app when publishing the new msg from the ros topic "cmd_vel"
    }
}
