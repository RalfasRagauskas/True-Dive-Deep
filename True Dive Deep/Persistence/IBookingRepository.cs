﻿using True_Dive_Deep.Models;

namespace True_Dive_Deep.Persistence
{
    public interface IBookingRepository
    {
        void Add(Booking booking);
        void Delete(int id);
        List<Booking> GetAll();
        Booking? GetById(int id);
        void Update(Booking booking);
    }
}