// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------

using SAPB1_FrameWork.Core.Models.Exceptions.ConnectionService;

namespace SAPB1_FrameWork.Core.Services.Connection
{
    public partial class ConnectionService
    {
        private void ValidateConnectionString(string connection)
        {
            Validate(
                        (Rule: IsInvalid(connection), Parameter: nameof(connection)),
                        (Rule: SizeIsInvalid(connection), Parameter: nameof(connection))
                    );
        }

        private static dynamic IsInvalid(string connection) => new
        {
            Condition = String.IsNullOrEmpty(connection),
            Message = "The connection string cannot be null or empty."
        };

        private static dynamic SizeIsInvalid(string connection) => new
        {
            Condition = connection.Length != 96,
            Message = "The connection string must have 96 characters."
        };

        private void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var connectionServiceException = new ConnectionStringValidationException();

            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    if (connectionServiceException.Data.Contains(parameter))
                    {
                        (connectionServiceException.Data[parameter] as List<string>)?.Add(rule.Message);
                    }
                    else
                    {
                        connectionServiceException.Data.Add(parameter, new List<string> { rule.Message });
                    }
                }
            }

            if (connectionServiceException.Data.Count > 0)
            {
                throw connectionServiceException;
            }
        }
    }
}
