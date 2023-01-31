﻿using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSercviceCenter.Orm.Repositories {
    public interface IEntityRepo<TEntity>
        where TEntity : IEntityBase {
        IList<TEntity> GetAll();
        TEntity? GetById(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
