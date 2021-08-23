using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Factory
{
    /// <summary>
    /// Factory used to create layers.
    /// </summary>
    public class NeuralLayerFactory
    {
        public Classes.NeuralLayer CreateNeuralLayer(int numberOfNeurons,
            Interfaces.IActivationFunction activationFunction,
            Interfaces.IInputFunction inputFunction)
        {
            var layer = new Classes.NeuralLayer();

            for (int i = 0; i < numberOfNeurons; i++)
            {
                var neuron = new Classes.Neuron(activationFunction, inputFunction);
                layer.Neurons.Add(neuron);
            }

            return layer;
        }
    }
}
