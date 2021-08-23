using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Classes
{
    public class InputSynapse : Interfaces.ISynapse
    {
        internal Interfaces.INeuron _toNeuron;

        public double Weight { get; set; }
        public double Output { get; set; }
        public double PreviousWeight { get; set; }

        public InputSynapse(Interfaces.INeuron toNeuron)
        {
            _toNeuron = toNeuron;
            Weight = 1;
        }

        public InputSynapse(INeuron toNeuron, double output)
        {
            _toNeuron = toNeuron;
            Output = output;
            Weight = 1;
            PreviousWeight = 1;
        }

        public double GetOutput()
        {
            return Output;
        }

        public bool IsFromNeuron(Guid fromNeuronId)
        {
            return false;
        }

        public void UpdateWeight(double learningRate, double delta)
        {
            throw new InvalidOperationException("It is not allowed to call this method on Input Connecion");
        }
    }
}
