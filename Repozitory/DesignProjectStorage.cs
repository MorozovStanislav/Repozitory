using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class DesignProject
    {
        public class DesignProjectStorage
        {
            private Dictionary<int, DesignProject> DesignProjects { get; } = new Dictionary<int, DesignProject>();

            public void Create(DesignProject designProject)
            {
                DesignProjects.Add(designProject.DesignProjectId, designProject);
            }

            public DesignProject Read(int designProjectId)
            {
                return DesignProjects[designProjectId];
            }

            public DesignProject Update(int designProjectId, DesignProject newDesignProject)
            {
                DesignProjects[designProjectId] = newDesignProject;
                return DesignProjects[designProjectId];
            }

            public bool Delete(int designProjectId)
            {
                return DesignProjects.Remove(designProjectId);
            }
        }
    }
}