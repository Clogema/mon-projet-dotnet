using System;
using System.Collections.Generic;
using Isen.DotNet.Library.Models.Base;

namespace Isen.DotNet.Library.Repositories.Interfaces
{
    public interface IBaseRepository<T>
        where T : BaseModel
    {
        // Listes
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);
        T Single(int id);
        T Single(string name);

        // Delete
        void Delete(int id);
        void Delete(T model);
        void DeleteRange(IEnumerable<T> models);
        void DeleteRange(params T[] models);

        // Update
        void Update(T model);
        void UpdateRange(IEnumerable<T> models);
        void UpdateRange(params T[] models);
    }
}