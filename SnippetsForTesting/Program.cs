using System;

namespace SnippetsForTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            var actionFuncLambdaObj = new ActionFuncLambda();
            Console.WriteLine(actionFuncLambdaObj.DoTheStringReverse("Hello World!"));
            Console.WriteLine(actionFuncLambdaObj.StringReverseWithNormalDelegate("Hello World 1234!"));
            Console.WriteLine(actionFuncLambdaObj.StringReverseWithNormalDelegateAnonymousMethod("Hello World 1234567!"));
            Console.WriteLine(actionFuncLambdaObj.StringReverseWithFunc("Hello World 12345678!"));
            actionFuncLambdaObj.StringReverseWithAction("Hello World 1234567890!");
        }

    }
}
