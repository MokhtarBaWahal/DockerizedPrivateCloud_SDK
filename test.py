import rospy
from std_msgs.msg import Float32
from geometry_msgs.msg import Twist
from sensor_msgs.msg import CompressedImage

def control_callback(data):
    print('IMPLEMENT CALLBACK control_callback')

def metric_callback(data):
    print('IMPLEMENT CALLBACK metric_callback')

def cam_callback(data):
    print('IMPLEMENT CALLBACK cam_callback')

def ultra_sonic_unity_callback(data):
    print('IMPLEMENT CALLBACK ultra_sonic_unity_callback')

rospy.init_node('test')


cmd_vel_pub = rospy.Publisher('/cmd_vel', Twist, queue_size=10)

control_sub = rospy.Subscriber('/control',String,control_callback)
            
metric_sub = rospy.Subscriber('/metric',String,metric_callback)
            
cam_sub = rospy.Subscriber('/cam',CompressedImage,cam_callback)
            
ultra_sonic_unity_sub = rospy.Subscriber('/ultra_sonic_unity',Float32,ultra_sonic_unity_callback)
            