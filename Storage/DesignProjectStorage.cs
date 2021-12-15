using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class DesignProjectStorage
    {
        private static Dictionary<int, DesignProject> DesignProjects { get; } = new Dictionary<int, DesignProject>();

        public static void Create(DesignProject designProject)
        {
            DesignProjects.Add(designProject.DesignProjectId, designProject);
        }

        public static DesignProject Read(int designProjectId)
        {
            return DesignProjects[designProjectId];
        }

        public static DesignProject Update(int designProjectId, DesignProject newDesignProject)
        {
            DesignProjects[designProjectId] = newDesignProject;
            return DesignProjects[designProjectId];
        }

        public static bool Delete(int designProjectId)
        {
            return DesignProjects.Remove(designProjectId);
        }
    }
}