﻿namespace RunGroupAplication.ViewModels;

using Models;
using Enum;
public class CreateClubViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ShortDescription { get; set; }
    public string LongDescription { get; set; }
    public IFormFile Image { get; set; }

    public Address Address { get; set; }
    public ClubCategory ClubCategory { get; set; }

    public string AppUserId { get; set; }

}
