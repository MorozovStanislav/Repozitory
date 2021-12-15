using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public static class Storage
    {
        public static CustomerStorage CustomerStorage { get; } = new CustomerStorage();
        public static DesignProjectStorage DesignProjectStorage { get; } = new DesignProjectStorage();
        public static MaterialOrdersStorage MaterialOrdersStorage { get; } = new MaterialOrdersStorage();
        public static MaterialsStorage MaterialsStorage { get; } = new MaterialsStorage();
        public static MaterialWarehouseStorage MaterialWarehouseStorage { get; } = new MaterialWarehouseStorage();
        public static PackageStorage PackageStorage { get; } = new PackageStorage();
        public static ProviderStorage ProviderStorage { get; } = new ProviderStorage();
        public static ReviewsStorage ReviewsStorage { get; } = new ReviewsStorage();
        public static ShoeOrdersStorage ShoeOrdersStorage { get; } = new ShoeOrdersStorage();
        public static ShoesStorage ShoesStorage { get; } = new ShoesStorage();
        public static ShoeWarehouseStorage ShoeWarehouseStorage { get; } = new ShoeWarehouseStorage();
        public static StoreAccountStorage StoreAccountStorage { get; } = new StoreAccountStorage();
        public static WishesStorage WishesStorage { get; } = new WishesStorage();
    }
}