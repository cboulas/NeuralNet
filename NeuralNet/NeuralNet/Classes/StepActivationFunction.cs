using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Classes
{
    public class StepActivationFunction : Interfaces.IActivationFunction
    {
        private double _treshold;

        public StepActivationFunction(double treshold)
        {
            _treshold = treshold;
        }

        public double CalculateOutput(double input)
        {
            return Convert.ToDouble(input > _treshold);
        }
    }
}
