using System;
using Cedro.Application.Interfaces;
using Cedro.Application.ViewModels;

namespace Cedro.Application.ApplicationServices
{
    public class RestaurantApplicationService : IRestaurantApplicationService
    {
        public RestaurantApplicationService()
        {
            
        }
        public RestaurantViewModel GetByName(string name)
        {
            throw new NotImplementedException();
        }
        public RestaurantViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}