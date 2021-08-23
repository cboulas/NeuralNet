using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Interfaces
{
    public interface IInputFunction
    {
        double CalculateInput(List<ISynapse> inputs);
    }
}
