using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Interfaces
{
    public interface IActivationFunction
    {
        double CalculateOutput(double input);
    }
}
