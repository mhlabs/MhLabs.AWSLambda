using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.Lambda.Core;
using Newtonsoft.Json;

namespace MhLabs.AWSLambda
{
    public abstract class LambdaBase<TInput, TOutput>
    {
        protected LambdaBase()
        {

        }

        [LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
        public async Task<TOutput> Handle(Stream inputStream, ILambdaContext context)
        {
            using (var sr = new StreamReader(inputStream))
            {
                var str = sr.ReadToEnd();
                var input = JsonConvert.DeserializeObject<TInput>(str);
                return await HandleInput(input, context);
            }
        }
        public abstract Task<TOutput> HandleInput(TInput input, ILambdaContext context);
    }
}
