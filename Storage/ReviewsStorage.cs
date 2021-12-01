using Shoe_store.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Shoe_store.Storage
{
    public class Reviews
    {
        public class ReviewsStorage
        {
            private Dictionary<int, Reviews> Reviewsx { get; } = new Dictionary<int, Reviews>();

            public void Create(Reviews reviews)
            {
                Reviewsx.Add(reviews.ReviewsId, reviews);
            }

            public Reviews Read(int reviewsId)
            {
                return Reviewsx[reviewsId];
            }

            public Reviews Update(int reviewsId, Reviews newReviews)
            {
                Reviewsx[reviewsId] = newReviews;
                return Reviewsx[reviewsId];
            }

            public bool Delete(int reviewsId)
            {
                return Reviewsx.Remove(reviewsId);
            }
        }
    }
}