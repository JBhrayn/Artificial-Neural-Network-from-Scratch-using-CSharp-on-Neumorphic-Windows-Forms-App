# ANN-MLP (from scratch) - a school project
This project consists of an implementation of a Multi-Layer Perceptron, along with a User Interface which provides functionality for creating, training, and testing its models.

*Training with 60000 training samples and 10000 testing samples from MNIST Handwritten DIGITS*
![](https://github.com/JBhrayn/NN_PROGLAN/blob/main/Resources/Test/On%20Training.png)

Stochastic Gradient Descent will be used as the optimization algorithm for built models, and the training dataset will be shuffled every epoch to lessen the likelihood of overfitting.

*Here's a training and testing result, with 40000 training samples and 8000 testing samples from MNIST Handwritten DIGITS*
![A model trained and tested with MNIST Handwritten Dataset](https://github.com/JBhrayn/NN_PROGLAN/blob/main/Resources/Test/Manual%20Testing%20After%20Training%20and%20Testing.png)

## NOTE
Controls for testing a model are enabled only if the loaded/current model is already trained.

I deliberately disabled the following textboxes:  
**• Input Layer Nodes**, since its value will be automatically filled according to the pixel dimension of the given dataset samples, e.g. 784 for 28x28 images.  
**• Output Layer Nodes**, since its value will be automatically filled according to the number of category or distinct labels found in the given dataset.  
**• Batch Size**, since this model uses Stochastic Gradient Descent as its optimization algorithm.  

I haven't added an input validation on the textboxes yet, so please provide an appropriate input for the enabled textboxes:

Also, the feature for saving and loading models is not yet functional, and much of the code probably needs refactoring.
