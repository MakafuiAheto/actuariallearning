using System;
namespace actuariallearning.Courses.Interfaces
{
	public interface IRepository<V, T> where T:class
	{
		Task<T> getById(V EntityId);
		Task<IEnumerable<T>> getAllById(IEnumerable<V> EntityIds);
		void save(T Entity);
		void deleteById(V EntityId);
		void update(T Entity);
		void updateById(V EntityId);
		void delete(T Entity);
		void deleteAllById(IEnumerable<V> EntityId);
		void saveAll(IEnumerable<T> Entities);
	}
}

