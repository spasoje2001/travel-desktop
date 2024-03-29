﻿using InitialProject.Model.DAO;
using InitialProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.Controller
{
    public class TourReservationController
    {
        private readonly TourReservationDAO _reservationDAO;

        public TourReservationController()
        {
            _reservationDAO = new TourReservationDAO();
        }

        public List<TourReservation> GetAll()
        {
            return _reservationDAO.GetAll();
        }

        public TourReservation CreateReservation(int tourId, int guestId, int numberOfGuests)
        {
            TourReservation reservation = new()
            {
                TourId = tourId,
                GuestId = guestId,
                NumberOfGuests = numberOfGuests
            };
            return _reservationDAO.Save(reservation);
        }
    }
}
