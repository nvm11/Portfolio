#This programs a "Neural Network" which is part of a comlpex AI's "brain"
#This network recieves random values of a variable and attempts to plot the points' slope
import numpy as np #imports numpy library
from numpy import random #imports random module from numpy
import matplotlib.pyplot as plt #allows program to plot a graph


class Neuron:
    def __init__(self):
        random.seed(1) #command that generates the same random values
        self.weights = initial_weights = 2 * random. random((1,1)) - 1 

    def tanh_derivative(self, x):
        return 1 - np.tanh(x) ** 2
    def step(self, x):
        dot_product = np.dot(x, self.weights)
        return np.tanh(dot_product)
    def train(self, iterations, train_inputs, train_outputs):
        for i in range(iterations):
            output = self.step(train_inputs)
            error = train_outputs - output
            adjustment = np.dot(train_inputs.T, (error * self. tanh_derivative(output)))
            self.weights += adjustment

def function(x):
    return 2 * x
x = [i/100 for i in range(300)] #sets range for x values
y = [function(i/100) for i in range(300)] #sets range for y values
data = []
for i in range(300):
    data.append(function(i/100)+random.randint(1, 100)/50)
import matplotlib.pyplot as plt
plt.plot(data, "g.")
x = np.asarray([x])/100
y = np.asarray([y])/100


neuron = Neuron()
x = x.reshape(300, 1)
y = y.T
neuron.train(10000, x, y) #number of times the neuron is trained
constant = neuron.weights[0][0]
test_data = []
for i in x:
    test_data.append(i*100*constant)
plt.plot(data, "bo") #data plotted on the graph (blue dots)
plt.plot(test_data, "r-") #neuron's attempt at finding the slope of the data (red line)
plt.show() #command to show graph
