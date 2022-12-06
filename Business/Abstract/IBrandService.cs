using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);
        IResult Delete(int id);
        IResult Update(Brand brand);
    }
}