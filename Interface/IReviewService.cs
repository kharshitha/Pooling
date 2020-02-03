using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Interface
{
    public interface IReviewService
    {
        public void AddReview(List<Review> reviews, Review review);
    }
}
