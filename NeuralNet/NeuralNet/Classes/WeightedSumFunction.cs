using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NeuralNet.Classes
{
    public class WeightedSumFunction : Interfaces.IInputFunction
    {
        public double CalculateInput(List<Interfaces.ISynapse> inputs)
        {
            return inputs.Select(x => x.Weight * x.GetOutput()).Sum();
        }
    }
}
