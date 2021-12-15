using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class MaterialsStorage
    {
        private static Dictionary<int, Materials> Materialsx { get; } = new Dictionary<int, Materials>();

        public static void Create(Materials materials)
        {
            Materialsx.Add(materials.MaterialsId, materials);
        }

        public static Materials Read(int materialsId)
        {
            return Materialsx[materialsId];
        }

        public static Materials Update(int materialsId, Materials newMaterials)
        {
            Materialsx[materialsId] = newMaterials;
            return Materialsx[materialsId];
        }

        public static bool Delete(int materialsId)
        {
            return Materialsx.Remove(materialsId);
        }
    }
}