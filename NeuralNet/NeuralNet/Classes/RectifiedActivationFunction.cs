﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNet.Classes
{
    public class RectifiedActivationFuncion : IActivationFunction
    {
        public double CalculateOutput(double input)
        {
            return Math.Max(0, input);
        }
    }
}
