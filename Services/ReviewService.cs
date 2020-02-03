using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Interface;

namespace Services
{
    public class ReviewService:IReviewService
    {
        public void AddReview(List<Review> reviews, Review review)
        {
            reviews.Add(review);
        }
    }
}
