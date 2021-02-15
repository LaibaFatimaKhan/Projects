import random
import time

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

    watch_Add = Stopwatch()
    watch_update = Stopwatch()
    watch_top = Stopwatch()

    def add(t, ID, lvl):
        if find(ID)==-1:    
            t.append((ID,lvl))
            x = sorted(t, key=lambda tup: tup[1])
            return x
        '''else:
            print("Patient ID already taken.")'''
    
    #find the product id and output the price corresponding to the id
    def find(ID):
        for j in t:
            if j[0] == ID:
                return j[1]   
        return -1

    def updated(t):
        t.remove(t[0])
        x = sorted(t, key=lambda tup: tup[1])
        return x

    def top(t):
        return t[0]

    print("Input number of expected patients here:")
    q = int(input())
    t = []*(256)
    ID = 1
    lvl = random.randint(1,5)
    '''print("First in:",add(t, ID, lvl))
    print("Queue:",updated(t))'''

    
    for i in range(2, q):
        ID = i
        lvl = random.randint(1,5)
        watch_Add.start()
        t = add(t, ID, lvl)
        watch_Add.stop()
        print(t)
        if i%2==0:
            watch_update.start()
            '''print("Now treating:",top(t),"\nQueue:",updated(t))'''
            watch_update.stop()
    print("Add time for",q,"patients is", watch_Add.time_elapsed(),"milli-seconds")
    watch_Add.reset()


    
