# Purpose
Intended to minimise boilerplate code when writing .NET Core Lambda functions that run in AWS Step Functions. 

# Usage

```
public class ParseMemberDetails : LambdaBase<Input, Output>
    {
        public override async Task<TranscriptDetailsModel> HandleInput(Input input, ILambdaContext context)
        {
            //handle your input 
            return new Output();
        }
    }
```
