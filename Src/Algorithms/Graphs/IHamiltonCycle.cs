using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Graphs
{
    public interface IHamiltonCycle : IGraph
    {
        bool IsHamiltonCycle();
    }
}
