import rospy
from std_msgs.msg import String
from sensor_msgs.msg import CompressedImage
from geometry_msgs.msg import Twist

def control_callback(data):
    print('IMPLEMENT CALLBACK control_callback')

def metric_callback(data):
    print('IMPLEMENT CALLBACK metric_callback')

def cam_callback(data):
    print('IMPLEMENT CALLBACK cam_callback')

rospy.init_node('test')


cmd_vel_pub = rospy.Publisher('/cmd_vel', Twist, queue_size=10)

control_sub = rospy.Subscriber('/control',String,control_callback)
            
metric_sub = rospy.Subscriber('/metric',String,metric_callback)
            
cam_sub = rospy.Subscriber('/cam',CompressedImage,cam_callback)
            