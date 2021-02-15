#!/bin/python3
import time
import math
import os
import random
import re
import sys
from enum import Enum
class Stopwatch(object):

    def __init__(self):
        """Initialize a new Stopwatch, but do not start timing."""
        self.start_time = None
        self.elapsed_time = 0

    def start(self):
        """Start timing."""
        self.start_time = time.time()*1000

    def stop(self):
        """Stop timing."""
        if not (self.start_time):
            return
        stop_time = time.time()*1000
        self.elapsed_time += int(round(stop_time - self.start_time))
        self.start_time = None

    def time_elapsed(self):
        if (self.start_time):
            self.stop()
       
        return self.elapsed_time

    def reset(self):
        self.start_time = None
        self.elapsed_time = 0
        
class PriorityQueue(object):
    
    def __init__(self):
        self.priority_queue=[]
        self.size=0
        self.total_injury_levels=5
        #since 5 injury levels:
        for i in range(0,self.total_injury_levels):
            self.priority_queue.append([])
            
    def priority(self,id):
        return id%4
    
    def add_to_pqueue(self,id):
        priority=self.priority(id)
        if not self.find_id(id):
            self.priority_queue[priority].append(id)
            self.size+=1
        
    def find_id(self,id):
        priority=self.priority(id)
        if id in self.priority_queue[priority]:
            return True
        return False
        
    def remove_highest_priority(self):
        if self.size>0:
            for i in range((self.total_injury_levels-1)):
                if self.priority_queue[i]:
                    self.size-=1
                    x = self.priority_queue[i].pop(0)
                    return x
                    
        return "Priority Queue is Empty, no patient to handle."
            
    def get_size(self):
        return self.size
    
if __name__ == '__main__':

    watch_add=Stopwatch()
    watch_find=Stopwatch()
    watch_remove= Stopwatch()

    patients_data = PriorityQueue()

    #######   ADD   #######
    add_patient= int(input("How many patients to add?"))
    for add_itr in range(add_patient):
        patient_id = add_itr
        
        watch_add.start()
        patients_data.add_to_pqueue(patient_id)
        watch_add.stop()
    #print(patients_data.priority_queue)    
    print("PRIORITY_QUEUE_ADD_TIME for",add_patient,"inputs is", watch_add.time_elapsed(),"milli seconds")
    watch_add.reset()
        

    #######   GET SIZE   #######
    print("Patients Data Size:",patients_data.get_size())

    ''' #######   FIND   #######
    find_patient= int(input("How many patients to find?"))
    for find_itr in range(find_patient):
        patient_id = random.randint(0,10**8)
        
        watch_find.start()
        patients_data.find_id(patient_id)
        watch_find.stop()
    print(patients_data.priority_queue)
        
    print("PRIORITY_QUEUE_FIND_TIME for",find_patient,"inputs is", watch_find.time_elapsed(),"milli seconds")
    watch_find.reset()
    '''
    
    #######   REMOVE   #######
    remove_patient= int(input("How many patients are to be treated?"))
    
    for remove_itr in range(remove_patient):
        
        watch_remove.start()
        #print(patients_data.remove_highest_priority())
        patients_data.remove_highest_priority()
        watch_remove.stop()

    print("PRIORITY_QUEUE_REMOVE_TIME for",remove_patient,"inputs is", watch_remove.time_elapsed(),"milli seconds")
    watch_remove.reset()
