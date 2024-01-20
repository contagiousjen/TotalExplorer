using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalExplorer
{
    internal class Operation
    {
        public Operation(OperationType typeOfOperation, string fileLocation, string? optionalFileLocation = null)
        {
            TypeOfOperation = typeOfOperation;
            FileLocation = fileLocation;
            OptionalFileLocation = optionalFileLocation;
        }

        public OperationType TypeOfOperation { get; }
        public string FileLocation { get; }
        public string? OptionalFileLocation { get; }

        public enum OperationType
        {
            Move,
            Delete,
            Create
        }
    }
}
