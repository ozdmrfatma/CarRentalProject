using Core.Utilities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
    //GetById, GetAll, Add, Update, Delete
}
