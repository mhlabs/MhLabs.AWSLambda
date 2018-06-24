# Purpose
Intended to minimise boilerplate code when writing .NET Core Lambda functions.

Make your lambda handler class inherit LambdaBase<TInput, TOutput>. The base class will handle deserialisation of the input Stream to your input object.

Note - if your function is triggered by an event, cosider using https://github.com/mhlabs/MhLabs.AwsLambdaSqsRetry instead

# Usage

```
public class YouLambdaFunction : LambdaBase<Input, Output>
    {
        public override async Task<Output> HandleInput(Input input, ILambdaContext context)
        {
            //handle your input 
            return new Output();
        }
    }
```
