using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntitites;
using Data.Model;
using Data.Repository.Interface;

namespace Data.Repository
{
    public class PassengerRepository : IPassangerRepository
    {
        private readonly PassengerEntities db;
        public PassengerRepository()
        {
            db = new PassengerEntities();
        }
        public List<PassengerView> GetAllPassengers()
        {
            var entity = db.Passengers.ToList();
            List<PassengerView> list = new List<PassengerView>();
            if (db != null)
            {
                foreach (var item in entity)
                {
                    PassengerView passenger = new PassengerView();
                    passenger.PassengerNumber = item.PassengerNumber;
                    passenger.FirstName = item.FirstName;
                    passenger.LastName = item.LastName;
                    passenger.PhoneNo = item.PhoneNo;
                    list.Add(passenger);
                }
            }
            return list;
        }
        public string CreateNewPassneger(PassengerView model)
        {
            try
            {
                if (model != null)
                {
                    Passenger passenger = new Passenger();
                    passenger.PassengerNumber = model.PassengerNumber;
                    passenger.FirstName = model.FirstName;
                    passenger.LastName = model.LastName;
                    passenger.PhoneNo = model.PhoneNo;
                    db.Passengers.Add(passenger);
                    db.SaveChanges();
                    return "Added succeffuly";
                }
                return "Model is null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public bool DeletePassneger(int? Id)
        {
            var entity = db.Passengers.Find(Id);
            if (entity != null)
            {
                db.Passengers.Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;

        }
        public string UpdatePassneger(int id, PassengerView model)
        {
            try
            {
                Passenger entity = db.Passengers.Find(id);
                if (model != null)
                {
                    entity.PassengerNumber = model.PassengerNumber;
                    entity.FirstName = model.FirstName;
                    entity.LastName = model.LastName;
                    entity.PhoneNo = model.PhoneNo;
                    db.Entry(entity).State = EntityState.Modified;
                    db.SaveChanges();
                    return "Passenger updated";
                }
                return "Model is null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public PassengerView GetPassneger(int? Id)
        {
            try
            {
                var entity = db.Passengers.Find(Id);
                PassengerView passenger = new PassengerView();
                passenger.PassengerNumber = entity.PassengerNumber;
                passenger.FirstName = entity.FirstName;
                passenger.LastName = entity.LastName;
                passenger.PhoneNo = entity.PhoneNo;
                return passenger;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
