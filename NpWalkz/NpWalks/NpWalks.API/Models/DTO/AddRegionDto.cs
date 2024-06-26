﻿namespace NpWalks.API.Models.DTO
{
    public class AddRegionDto
    {
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string? RegionImageUrl { get; set; } //? is used to make nullable
    }
}

