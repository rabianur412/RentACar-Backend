﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetCarsByColorId(int id);
        IDataResult<List<Car>> SetCarsDailyPrice(decimal min);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
