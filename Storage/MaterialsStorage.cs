using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Materials
    {
        public class MaterialsStorage
        {
            private Dictionary<int, Materials> Materialsx { get; } = new Dictionary<int, Materials>();

            public void Create(Materials materials)
            {
                Materialsx.Add(materials.MaterialsId, materials);
            }

            public Materials Read(int materialsId)
            {
                return Materialsx[materialsId];
            }

            public Materials Update(int materialsId, Materials newMaterials)
            {
                Materialsx[materialsId] = newMaterials;
                return Materialsx[materialsId];
            }

            public bool Delete(int materialsId)
            {
                return Materialsx.Remove(materialsId);
            }
        }
    }
}