using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet.Classes
{
    public class NeuralLayer
    {
        public List<Interfaces.INeuron> Neurons;

        public NeuralLayer()
        {
            Neurons = new List<Interfaces.INeuron>();
        }

        /// <summary>
        /// Connecting two layers.
        /// </summary>
        public void ConnectLayers(NeuralLayer inputLayer)
        {
            var combos = Neurons.SelectMany(neuron => inputLayer.Neurons, (neuron, input) => new { neuron, input });
            combos.ToList().ForEach(x => x.neuron.AddInputNeuron(x.input));
        }
    }
}
