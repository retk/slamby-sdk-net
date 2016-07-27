﻿using System.ComponentModel.DataAnnotations;

namespace Slamby.SDK.Net.Models.Services
{
    public class PrcRecommendationRequest : PrcRecommendationBaseRequest
    {
        [Required]
        public string Text { get; set; }
    }
}
