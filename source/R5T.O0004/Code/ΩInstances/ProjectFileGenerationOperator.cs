using System;


namespace R5T.O0004
{
    public class ProjectFileGenerationOperator : IProjectFileGenerationOperator
    {
        #region Infrastructure

        public static IProjectFileGenerationOperator Instance { get; } = new ProjectFileGenerationOperator();


        private ProjectFileGenerationOperator()
        {
        }

        #endregion
    }
}
