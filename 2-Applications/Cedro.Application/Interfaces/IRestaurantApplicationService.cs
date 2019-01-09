using System;
using Cedro.Application.ViewModels;

namespace Cedro.Application.Interfaces
{
    public interface IRestaurantApplicationService : IDisposable
    {
         RestaurantViewModel  GetById(Guid id);
         RestaurantViewModel GetByName(string name);
    }
}