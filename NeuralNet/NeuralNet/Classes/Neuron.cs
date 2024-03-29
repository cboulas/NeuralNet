﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuralNet.Classes
{
    public class Neuron : Interfaces.INeuron
    {
        private Interfaces.IActivationFunction _activationFunction;
        private Interfaces.IInputFunction _inputFunction;

        /// <summary>
        /// Input connections of the neuron.
        /// </summary>
        public List<Interfaces.ISynapse> Inputs { get; set; }

        /// <summary>
        /// Output connections of the neuron.
        /// </summary>
        public List<Interfaces.ISynapse> Outputs { get; set; }

        public Guid Id { get; private set; }

        /// <summary>
        /// Calculated partial derivate in previous iteration of training process.
        /// </summary>
        public double PreviousPartialDerivate { get; set; }

        public Neuron(Interfaces.IActivationFunction activationFunction, Interfaces.IInputFunction inputFunction)
        {
            Id = Guid.NewGuid();
            Inputs = new List<Interfaces.ISynapse>();
            Outputs = new List<Interfaces.ISynapse>();

            _activationFunction = activationFunction;
            _inputFunction = inputFunction;
        }

        /// <summary>
        /// Connect two neurons. 
        /// This neuron is the output neuron of the connection.
        /// </summary>
        /// <param name="inputNeuron">Neuron that will be input neuron of the newly created connection.</param>
        public void AddInputNeuron(Interfaces.INeuron inputNeuron)
        {
            var synapse = new Synapse(inputNeuron, this);
            Inputs.Add(synapse);
            inputNeuron.Outputs.Add(synapse);
        }

        /// <summary>
        /// Connect two neurons. 
        /// This neuron is the input neuron of the connection.
        /// </summary>
        /// <param name="outputNeuron">Neuron that will be output neuron of the newly created connection.</param>
        public void AddOutputNeuron(Interfaces.INeuron outputNeuron)
        {
            var synapse = new Synapse(this, outputNeuron);
            Outputs.Add(synapse);
            outputNeuron.Inputs.Add(synapse);
        }

        /// <summary>
        /// Calculate output value of the neuron.
        /// </summary>
        /// <returns>
        /// Output of the neuron.
        /// </returns>
        public double CalculateOutput()
        {
            return _activationFunction.CalculateOutput(_inputFunction.CalculateInput(this.Inputs));
        }

        /// <summary>
        /// Input Layer neurons just receive input values.
        /// For this they need to have connections.
        /// This function adds this kind of connection to the neuron.
        /// </summary>
        /// <param name="inputValue">
        /// Initial value that will be "pushed" as an input to connection.
        /// </param>
        public void AddInputSynapse(double inputValue)
        {
            var inputSynapse = new InputSynapse(this, inputValue);
            Inputs.Add(inputSynapse);
        }

        /// <summary>
        /// Sets new value on the input connections.
        /// </summary>
        /// <param name="inputValue">
        /// New value that will be "pushed" as an input to connection.
        /// </param>
        public void PushValueOnInput(double inputValue)
        {
            ((InputSynapse)Inputs.First()).Output = inputValue;
        }
    }
}
