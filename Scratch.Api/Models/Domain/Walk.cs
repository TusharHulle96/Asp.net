﻿using Scratch.Api.Models.Domain;

namespace ScratchDbContext.Api.Models.Domain
{   
    public class Walk
    {
        public int  Id { get; set; }

        public string ? Name { get; set; }

        public double Length { get; set; }

        public Guid RegionId { get; set; }

        public Guid WalkDifficultyId { get; set; }

        //Navigation Property

        public Region ? Region { get; set; }

        public WalkDifficulty ? WalkDifficulty { get; set; } 
      
    }
}
