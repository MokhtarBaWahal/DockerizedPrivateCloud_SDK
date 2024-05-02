
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;  

public class metricSubscriber : MonoBehaviour
{
    void Start()
    {
        // start the ROS connection
        ROSConnection.GetOrCreateInstance().Subscribe<StringMsg>("metric", metric_OnMsgReceived);
    }

    void metric_OnMsgReceived (StringMsg msg )
    {
        // Add the logic of your app when receiving the new msg from the ros topic metric.
    }
}
