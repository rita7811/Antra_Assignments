using System;

namespace Antra_Assignment_4_Cs.GenericRepository
{
	public interface IRepository<T> where T : class
	{
		void Add(T item);
		void Remove(T item);
		void Save();
		IEnumerable<T> GetAll();
		T GetByld(int id);
	}
}

