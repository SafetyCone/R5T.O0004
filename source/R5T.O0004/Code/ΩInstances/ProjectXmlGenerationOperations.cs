using System;


namespace R5T.O0004
{
    public class ProjectXmlGenerationOperations : IProjectXmlGenerationOperations
    {
        #region Infrastructure

        public static IProjectXmlGenerationOperations Instance { get; } = new ProjectXmlGenerationOperations();


        private ProjectXmlGenerationOperations()
        {
        }

        #endregion
    }
}
