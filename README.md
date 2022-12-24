# ANN-MLP (from scratch) - a school project
This project consists of an implementation of a Multi-Layer Perceptron, along with a User Interface which provides functionality for creating, training, and testing its models.  
![](https://github.com/JBhrayn/NN_PROGLAN/blob/main/Resources/NewFolder/On%20Training.png)

Stochastic Gradient Descent will be used as the optimization algorithm for built models, and the training dataset will be shuffled at each iteration to lessen the likelihood of overfitting.

For now, the implementation does not have a bias term. Even so, by tuning the hyperparameters, one can create a remarkable model as shown below:  
![A model trained and tested with MNIST Handwritten Dataset](https://github.com/JBhrayn/NN_PROGLAN/blob/main/Resources/NewFolder/Manual%20Testing%20After%20Training%20and%20Testing.png)

## NOTE
Controls for testing a model are enabled only if the loaded/current model is already trained.

I deliberately disabled the following textboxes:  
**• Input Layer Nodes**, since its value will be automatically filled according to the pixel dimension of the given dataset samples, e.g. 784 for 28x28 images.  
**• Output Layer Nodes**, since its value will be automatically filled according to the number of category or distinct labels found in the given dataset.  
**• Batch Size**, since this model uses Stochastic Gradient Descent as its optimization algorithm.  

Also, the feature for saving and loading models is not yet functional, and much of the code probably needs refactoring.
