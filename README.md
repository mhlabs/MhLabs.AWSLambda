# Usage

```
public class ParseMemberDetails : StepFunctionsLambdaBase<Input, Output>
    {
        public override async Task<TranscriptDetailsModel> HandleInput(Input input, ILambdaContext context)
        {
            //handle your input 
            return new Output();
        }
    }
```
