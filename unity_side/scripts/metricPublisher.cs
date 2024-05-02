
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;  

public class metricSubscriber : MonoBehaviour
{

    void Start()
    {
        // start the ROS connection
        ROSConnection.GetOrCreateInstance().RegisterPublisher<StringMsg>("metric");
    }

    private void Update()
    {
        // Add the logic of your app when publishing the new msg from the ros topic "metric"
    }
}
