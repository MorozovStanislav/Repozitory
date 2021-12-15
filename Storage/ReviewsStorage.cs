using System.Collections.Generic;
using ShoeStore.Domains;

namespace Shoe_store.Storage
{
    public class ReviewsStorage
    {
        private static Dictionary<int, Reviews> Reviewsx { get; } = new Dictionary<int, Reviews>();

        public static void Create(Reviews reviews)
        {
            Reviewsx.Add(reviews.ReviewsId, reviews);
        }

        public static Reviews Read(int reviewsId)
        {
            return Reviewsx[reviewsId];
        }

        public static Reviews Update(int reviewsId, Reviews newReviews)
        {
            Reviewsx[reviewsId] = newReviews;
            return Reviewsx[reviewsId];
        }

        public static bool Delete(int reviewsId)
        {
            return Reviewsx.Remove(reviewsId);
        }
    }
}