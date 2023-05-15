using System;


namespace R5T.O0004
{
    public class ProjectFileGenerationOperations : IProjectFileGenerationOperations
    {
        #region Infrastructure

        public static IProjectFileGenerationOperations Instance { get; } = new ProjectFileGenerationOperations();


        private ProjectFileGenerationOperations()
        {
        }

        #endregion
    }
}
