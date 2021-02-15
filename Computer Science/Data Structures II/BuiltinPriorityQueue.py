#!/bin/python3
import time
import math
import os
import random
import re
import sys
from enum import Enum
from queue import PriorityQueue
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

if __name__ == '__main__':

    watch_add=Stopwatch()
    watch_remove= Stopwatch()
    patients_data = PriorityQueue()

    #######   ADD   #######
    add_patient= int(input("How many patients to add?"))
    for add_itr in range(add_patient):
        patient_id = add_itr
        priority=patient_id%4
        watch_add.start()
        patients_data.put((priority,patient_id))
        watch_add.stop()
    print("PRIORITY_QUEUE_ADD_TIME for",add_patient,"inputs is", watch_add.time_elapsed(),"milli seconds")
    watch_add.reset()
    
    #######   REMOVE   #######
    remove_patient= int(input("How many patients are to be treated?"))
    a=remove_patient
    
    while not patients_data.empty() and remove_patient>0:
        watch_remove.start()
        remove_patient-=1
        watch_remove.stop()

    print("PRIORITY_QUEUE_REMOVE_TIME for",a,"inputs is", watch_remove.time_elapsed(),"milli seconds")
    watch_remove.reset()
    
