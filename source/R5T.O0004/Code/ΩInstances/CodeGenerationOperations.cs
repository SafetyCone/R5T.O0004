using System;


namespace R5T.O0004
{
    public class CodeGenerationOperations : ICodeGenerationOperations
    {
        #region Infrastructure

        public static ICodeGenerationOperations Instance { get; } = new CodeGenerationOperations();


        private CodeGenerationOperations()
        {
        }

        #endregion
    }
}
