import sys

sys.path.append("..")
import utilities.templates as templates
# import utilities.parse as parser

def write_unity_subscribers( subscribers):

        for sub in subscribers:

            with open(f"unity_side/scripts/{sub[0]}Subscriber.cs", "w") as file:
                file = templates.FileWriter(file=file)
                file.write_sub_header(type=sub[1])
                file.write_sub_class(type =sub[1], name =sub[0])
               
def write_unity_publishers(publisher_topics):

        for sub in publisher_topics:
           
            with open(f"unity_side/scripts/{sub[0]}Publisher.cs", "w") as file:
                file = templates.FileWriter(file=file)
                file.write_pub_header(type=sub[1])
                file.write_pub_class(type =sub[1], name =sub[0])


class UnityTopics:
    def __init__(self, node_info):

        self.node_info = node_info
        publisher_topics = []
        subscriber_topics = []
        for topic in self.node_info.node_publishers:
            if self.node_info.node_publishers[topic]["unity_pub_fag"] != 0:
                publisher_topics.append([self.node_info.node_publishers[topic]["name"], self.node_info.node_publishers[topic]["type"]]) 
            
            if self.node_info.node_publishers[topic]["unity_sub_fag"] != 0:
                subscriber_topics.append([self.node_info.node_publishers[topic]["name"], self.node_info.node_publishers[topic]["type"]]) 

        for topic in self.node_info.node_subscribers:
            if self.node_info.node_subscribers[topic]["unity_pub_fag"] != 0:
                publisher_topics.append([self.node_info.node_subscribers[topic]["name"], self.node_info.node_subscribers[topic]["type"]]) 
            
            if self.node_info.node_subscribers[topic]["unity_sub_fag"] != 0:
                subscriber_topics.append([self.node_info.node_subscribers[topic]["name"], self.node_info.node_subscribers[topic]["type"]]) 

        # change it to check on created arrays 
        if subscriber_topics:
           write_unity_subscribers(subscriber_topics)
        if publisher_topics:
           write_unity_publishers(publisher_topics)
       
        