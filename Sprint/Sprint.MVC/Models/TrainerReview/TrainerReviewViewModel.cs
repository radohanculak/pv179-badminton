﻿using Sprint.BL.Dto.TrainerReview;

namespace Sprint.MVC.Models.TrainerReview;

public class TrainerReviewViewModel
{
    public TrainerReviewDto Review { get; set; }
    public Guid TrainerReservationId { get; set; }

    public TrainerReviewViewModel(Guid trainResId)
    {
        TrainerReservationId = trainResId;
    }
    
    public TrainerReviewViewModel(Guid trainResId, TrainerReviewDto review) : this(trainResId)
    {
        Review = review;
    }
}